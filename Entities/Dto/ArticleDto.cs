using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class ArticleDto:IDto
    {
        public string SubjectName { get; set; }
        public string Path { get; set; }
        public string Author { get; set; }
    }
}
