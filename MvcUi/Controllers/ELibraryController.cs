using AutoMapper;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcUi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
namespace MvcUi.Controllers
{
    [AllowAnonymous]
    public class ELibraryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISubjectDal _subjectDal;
        private readonly UserManager<User> _userManager;

        public ELibraryController(IMapper mapper, ISubjectDal subjectDal, UserManager<User> userManager)
        {
            _mapper = mapper;
            _subjectDal = subjectDal;
            _userManager = userManager;
        }

        public async Task<IActionResult> Save(SubjectModel subjectModel)
        {
            Subject subject = new Subject
            {
                SubjectName = subjectModel.SubjectName
            };
            string guid = Guid.NewGuid().ToString() + ".pdf";

            using (var stream = new FileStream(guid, FileMode.Create))
            {
                await subjectModel.File.CopyToAsync(stream);
            }
            subject.Path = guid;
            subject.Author = HttpContext.User.Claims.LastOrDefault(x=>x.Type==ClaimTypes.Name).Value+" "+HttpContext.User.Claims.LastOrDefault(x => x.Type == ClaimTypes.Surname).Value;
            await _subjectDal.AddAsync(subject);
            return RedirectToAction("ELibrary","Home");
        }


        public async Task<IActionResult> GetSubject(string path)
        {
            return new FileStreamResult(new FileStream(path, FileMode.Open), "application/pdf");
        }
    }
}
