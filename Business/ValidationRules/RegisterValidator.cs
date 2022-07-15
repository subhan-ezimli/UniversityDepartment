using Entities.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class RegisterValidator : AbstractValidator<RegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").MinimumLength(2).WithMessage("Ən azı 2 simvol girməlisiniz");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").MinimumLength(2).WithMessage("Ən azı 2 simvol girməlisiniz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible).WithMessage("Düzgün e-poçt daxil edin");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz");
            //RuleFor(x => x.Password)

            //     .Matches(@"[!()@#$%^<>&*.,+=_|~-]").WithMessage("şifrədə [!()@#$%^<>&*.,+=_|~-]- xüsusi simvollardan biri istifadə olunmalıdır")
            //     .Ma(@"[A-Z]+").WithMessage("Şifrə ən azı bir böyük hərfdən ibarət olmalıdır")
            //     .Length(8, 35).WithMessage("Şifrə 8 və 35 simvol aralığında olamlıdır");
            RuleFor(x => x.Password).Must(HasValidPassword).WithMessage("Şirə ən az bir hərf , bir rəqəm və bir fərqli simvoldan ibarət olmalıdır") ;
        }

        private bool HasValidPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");

            return (lowercase.IsMatch(pw) && uppercase.IsMatch(pw) && digit.IsMatch(pw) && symbol.IsMatch(pw));
        }
    }
}
