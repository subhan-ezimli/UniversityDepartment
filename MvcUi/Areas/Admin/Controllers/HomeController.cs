using DataAccess.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        private readonly IFeedbackDal _feedbackDal;

        public HomeController(IFeedbackDal feedbackDal)
        {
            _feedbackDal = feedbackDal;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _feedbackDal.GetAllAsync();
            return View(result);
        }
        [Authorize("Admin")]
        public IActionResult Register()
        {
            return View();
        }

        [Authorize("Admin")]
        public IActionResult Register(RegisterDto registerDto)
        {
            return View();
        }


    }
}
