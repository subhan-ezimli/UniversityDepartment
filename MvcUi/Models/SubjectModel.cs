﻿using Entities.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUi.Models
{
    public class SubjectModel
    {
        public string SubjectName { get; set; }
        public IFormFile File { get; set; }
        public string Path { get; set; }
        public string Author { get; set; }
        public List<SubjectDto> SubjectDtos { get; set; }
    }
}
