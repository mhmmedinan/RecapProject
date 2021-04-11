using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IResult Add(CreditCard card);
        IDataResult<CreditCard> GetByUserId(int id);
        IDataResult<List<CreditCard>> GetAll(int userId);
    }
}
