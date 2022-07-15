using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class KafedraContext:IdentityDbContext<User>
    {
        public KafedraContext(DbContextOptions<KafedraContext> options) : base(options)
        {

        }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
