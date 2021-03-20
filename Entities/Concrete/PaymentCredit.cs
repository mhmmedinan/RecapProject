using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class PaymentCredit:IEntity
    {
        public decimal Amount { get; set; }
    }
}
