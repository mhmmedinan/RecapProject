using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class RentalPaymentCreditDto
    {
        public Rental Rental { get; set; }
        public PaymentCredit PaymentCredit { get; set; }
    }
}
