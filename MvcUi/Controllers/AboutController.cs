using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUi.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        public IActionResult HeadOfDepartment()
        {
            return View();
        }
    }
}
