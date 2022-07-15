using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUi.Controllers
{
    [AllowAnonymous]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackDal _feedbackDal;

        public FeedbackController(IFeedbackDal feedbackDal)
        {
            _feedbackDal = feedbackDal;
        }

        public async Task<IActionResult> Save(Feedback feedback)
        {
            await _feedbackDal.AddAsync(feedback);
            return RedirectToAction("Feedback", "Home");
        }

    }
}
