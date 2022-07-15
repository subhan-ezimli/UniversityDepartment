using Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class SubjectDto:IDto
    {
        public string SubjectName { get; set; }
        public string Path { get; set; }
        public string Author { get; set; }
    }
}
