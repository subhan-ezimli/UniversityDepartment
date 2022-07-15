using Entites.Enum;
using Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IdentityUser,IEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string Duty { get; set; }
        public bool Contributor { get; set; }
    }
}
