using Core.Utilities.Results;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public Task<IDataResult<string>> Login(LoginDto loginDto);
        public Task<IResult> Register(RegisterDto registerDto);
        public Task<IResult> LogOut();
    }
}
