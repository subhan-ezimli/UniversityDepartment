using Business.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }    

        [HttpPost("Register")]
        public async Task<JsonResult> Register([FromBody] UserRegisterDto userRegister)
        {
            try
            {
                var result = await _authService.RegisterAsync(userRegister);
                return new JsonResult(result);
            }  
            catch (Exception ex) 
            { 
                return new JsonResult(ex.Message);
            }
        }

        [HttpPost("RegisterComplete")]
        public async Task<JsonResult> RegisterCompleteAsync([FromBody] string code)
        {
            try 
            {
               
                var result = await _authService.RegisterCompleteAsync(code);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }

        [HttpPost("Login")]
        public async Task<JsonResult> Login([FromBody] UserLoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);
            return new JsonResult(result);
        }

    }
}