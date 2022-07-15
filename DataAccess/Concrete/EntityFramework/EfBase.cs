using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected KafedraContext _repositoryContext { get; set; }
        public EfBase(KafedraContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            var addedEntity = _repositoryContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            await _repositoryContext.SaveChangesAsync();

        }
        public async Task DeleteAsync(TEntity entity)
        {
            var deletedEntity = _repositoryContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            await _repositoryContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            var updatedEntity = _repositoryContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            await _repositoryContext.SaveChangesAsync();
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _repositoryContext.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await (filter == null
                ? _repositoryContext.Set<TEntity>().ToListAsync()
                : _repositoryContext.Set<TEntity>().Where(filter).ToListAsync());
        }
    }
}
