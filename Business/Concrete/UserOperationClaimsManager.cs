using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserOperationClaimsManager:IUserOperationClaimsService
    {
        private IUserOperationClaimsDal _claimsDal;

        public UserOperationClaimsManager(IUserOperationClaimsDal claimsDal)
        {
            _claimsDal = claimsDal;
        }

        public IResult Add(UserOperationClaim userOperationClaim)
        {
            _claimsDal.Add(userOperationClaim);
            return new SuccessResult();
        }

        public IResult Update(UserOperationClaim userOperationClaim)
        {
            _claimsDal.Update(userOperationClaim);
            return new SuccessResult();
        }

        public IResult Delete(UserOperationClaim userOperationClaim)
        {
            _claimsDal.Delete(userOperationClaim);
            return new SuccessResult();
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_claimsDal.GetAll());
        }

        public IDataResult<UserOperationClaim> GetById(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_claimsDal.Get(u => u.Id == id));
        }
    }
}
