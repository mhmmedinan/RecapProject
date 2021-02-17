using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("İsim boş bırakılamaz.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyisim boş bırakılamaz.");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Email boş bırakılamaz.");
            RuleFor(u => u.Password).MinimumLength(6).WithMessage("Password en az 6 karakter olmalı.");


        }
    }
}
