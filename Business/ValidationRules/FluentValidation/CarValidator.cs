using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük fiyatı 0'dan büyük olmalıdır.");
            RuleFor(c => c.Description).MinimumLength(5).WithMessage("Araç açıklaması en az 5 karakter uzunluğunda olmalıdır.");
            RuleFor(c => c.ModelYear).GreaterThan(0).WithMessage("Aracın model yılı 0'dan büyük olmalıdır.");
            RuleFor(c => c.BrandId).NotEmpty().WithMessage("Brand Id boş bırakılamaz.");
            RuleFor(c => c.ColorId).NotEmpty().WithMessage("Color Id boş bırakılamaz.");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Günlük fiyat boş bırakılamaz.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz.");
        }
    }
}
