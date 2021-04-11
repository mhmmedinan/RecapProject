using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CreditCardManager:ICreditCardService
    {
        private ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard card)
        {
            _creditCardDal.Add(card);
            return new SuccessResult(Messages.CreditCardAdded);
        }

        public IDataResult<CreditCard> GetByUserId(int id)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CreditCard>> GetAll(int userId)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(x => x.UserId == userId));
        }
    }
}
