using Entites.Enum;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class RegisterDto:IDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Duty { get; set; }
        public int Role { get; set; }
    }
}
