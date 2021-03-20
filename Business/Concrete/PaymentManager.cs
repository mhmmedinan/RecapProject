using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PaymentManager:IPaymentService
    {
        public IResult CreditPayment(PaymentCredit paymentCredit)
        {
          

            return new SuccessResult(Messages.PaymentCompleted);
        }
    }
}
