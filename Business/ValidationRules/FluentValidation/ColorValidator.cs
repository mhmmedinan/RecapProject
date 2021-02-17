﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorName).MinimumLength(2).WithMessage("Renk adı en az 2 karakter uzunluğunda olmalıdır.");
            RuleFor(c => c.ColorName).NotEmpty().WithMessage("Renk adı boş bırakılamaz. ");
        
        }
    }
}
