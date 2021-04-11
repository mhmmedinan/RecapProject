using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{ 
    public interface IUserOperationClaimsService
    {
        IResult Add(UserOperationClaim userOperationClaim);
        IResult Update(UserOperationClaim userOperationClaim);
        IResult Delete(UserOperationClaim userOperationClaim);

        IDataResult<List<UserOperationClaim>> GetAll();

        IDataResult<UserOperationClaim> GetById(int id);

    }
}
