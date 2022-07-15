using AutoMapper;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUi.Areas.Admin.Controllers
{

    [Area("admin")]
    [Authorize(Roles = "admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Register()
        {
            UserRegisterDto userRegisterDto = new UserRegisterDto();
            return View(userRegisterDto);
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            var mapped = _mapper.Map<UserRegisterDto, User>(userRegisterDto);
            mapped.UserName = Guid.NewGuid().ToString();
            mapped.Contributor = true;
            var result = await _userManager.CreateAsync(mapped, userRegisterDto.Password);
            if (result.Succeeded)
            {
                var result2 = await _userManager.AddToRoleAsync(mapped, userRegisterDto.Role);
                if (result2.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
            }
            return View(userRegisterDto);
        }
    }
}
