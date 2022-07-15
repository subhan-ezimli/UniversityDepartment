using AutoMapper;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using Core.Utilities.Results;
using Entities.Dto;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        public AuthManager(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<IDataResult<string>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (result)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                var userRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault();

                return new SuccessDataResult<string>(userRole, Messages.SuccessLogin);
            }
            return new ErrorDataResult<string>(Messages.FailLoginUser);
        }

        public async Task<IResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return new SuccessResult(Messages.EntityDeleted);
        }

        public async Task<IResult> Register(RegisterDto registerDto)
        {
            var mappedEntity = _mapper.Map<RegisterDto, User>(registerDto);
            mappedEntity.UserName = registerDto.Name + registerDto.SurName;
            var result = await _userManager.CreateAsync(mappedEntity, registerDto.Password);

            var resultaa = await _roleManager.CreateAsync(new IdentityRole("vacationer"));
            var roles = await _roleManager.Roles.ToListAsync();
            await _userManager.AddToRoleAsync(mappedEntity, "vacationer");
            if (result.Succeeded)
            {
                return new SuccessResult(Messages.SuccessRegister);
            }
            return new ErrorResult(result.Errors.FirstOrDefault().Description);
        }

    }
}
