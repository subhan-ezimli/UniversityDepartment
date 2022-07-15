using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Subject:IEntity
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string Path { get; set; }
        public string Author { get; set; }
    }
}
