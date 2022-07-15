using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFeedbackDal:EfBase<Feedback>,IFeedbackDal
    {
        public EfFeedbackDal(KafedraContext kafedraContext):base(kafedraContext)
        { 
        }
    }
}
