using AutoMapper;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcUi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcUi.Controllers
{
    [AllowAnonymous]
    public class ArticleController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IArticleDal _articleDal;

        public ArticleController(IMapper mapper, IArticleDal articleDal)
        {
            _mapper = mapper;
            _articleDal = articleDal;
        }

        public async Task<IActionResult> Save(ArticleModel articleModel)
        {
            Article article = new Article
            {
                SubjectName = articleModel.SubjectName
            };
            string guid = Guid.NewGuid().ToString() + ".pdf";

            using (var stream = new FileStream(guid, FileMode.Create))
            {
                await articleModel.File.CopyToAsync(stream);
            }
            article.Path = guid;
            article.Author = HttpContext.User.Claims.LastOrDefault(x => x.Type == ClaimTypes.Name).Value + " " + HttpContext.User.Claims.LastOrDefault(x => x.Type == ClaimTypes.Surname).Value;
            await _articleDal.AddAsync(article);
            return RedirectToAction("ScienceConferance", "Home");
        }


        public async Task<IActionResult> GetSubject(string path)
        {
            return new FileStreamResult(new FileStream(path, FileMode.Open), "application/pdf");
        }
    }
}
