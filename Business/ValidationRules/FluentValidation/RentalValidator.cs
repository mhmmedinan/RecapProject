using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage("Car Id boş bırakılamaz");
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage("Customer Id boş bırakılamaz");
        }
    }
}
