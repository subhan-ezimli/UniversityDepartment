using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {

        private readonly IAuthService _authService;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        public AuthController(IAuthService authService, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _authService = authService;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

       
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (result)
            {
                var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
                await _signInManager.UserManager.AddClaimAsync(user, new Claim(ClaimTypes.NameIdentifier, user.Id));
                await _signInManager.UserManager.AddClaimAsync(user, new Claim(ClaimTypes.Name, user.Name));
                await _signInManager.UserManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, role));
                await _signInManager.UserManager.AddClaimAsync(user, new Claim(ClaimTypes.Surname, user.SurName));
                await _signInManager.SignInAsync(user, isPersistent: true);


                var claims = new List<Claim>() {
                new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.Id)),
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Role, role),
                        new Claim(ClaimTypes.Surname,user.SurName)
                };
                //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity
                var principal = new ClaimsPrincipal(identity);
                //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
                {
                    IsPersistent = true
                });
                if (role == "candidate")
                {
                    return RedirectToAction("Index", "Home", new { Area = "candidate" });
                }
                else if (role == "admin")
                {
                    return RedirectToAction("Index", "Home", new { Area = "admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { Area = "teacher" });
                }
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            var result = await _authService.LogOut();
            if (result.Success)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}
