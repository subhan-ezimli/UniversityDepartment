using AutoMapper;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcUi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUi.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ISubjectDal _subjectDal;
        private readonly IArticleDal _articleDal;
        private readonly IMapper _mapper;

        public HomeController(ISubjectDal subjectDal, IMapper mapper, IArticleDal articleDal)
        {
            _subjectDal = subjectDal;
            _mapper = mapper;
            _articleDal = articleDal;
        }

        public IActionResult Index()
        {
            return View();
        }




        public IActionResult HeadOfDepartment()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Doctor()
        {
            return View();
        }
        public IActionResult Bachelor1()
        {
            return View();
        }
        public IActionResult Bachelor2()
        {
            return View();
        }

        public async Task<IActionResult> ScienceConferance()
        {
            var articles = await _articleDal.GetAllAsync();
            var mapped = _mapper.Map<List<Article>, List<ArticleDto>>(articles);
            ArticleModel articleModel = new ArticleModel();
            articleModel.ArticleDtos = mapped;
            return View(articleModel);
        }

        public IActionResult Cooperation()
        {
            return View();
        }
        public IActionResult Positions()
        {
            return View();
        }
        public async Task<IActionResult> ELibrary()
        {
            var subjects = await _subjectDal.GetAllAsync();
            var mapped = _mapper.Map<List<Subject>,List<SubjectDto>>(subjects);
            SubjectModel subjectModel = new SubjectModel();
            subjectModel.SubjectDtos = mapped;
            return View(subjectModel);
        }

        public IActionResult Master()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            Feedback feedback = new Feedback();
            return View(feedback);
        }
    }
}
