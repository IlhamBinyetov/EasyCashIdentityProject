using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public  class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be null");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("SurName can not be null");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName can not be null");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be null");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password can not be null");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword can not be null");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Maximum 30 charachters");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Minimum 30 charachters");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Passwords must be same!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Use correct email address!");
        }
    }
}
