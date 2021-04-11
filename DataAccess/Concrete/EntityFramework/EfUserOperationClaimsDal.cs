using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimsDal: EfEntityRepositoryBase<UserOperationClaim, CarContext>, IUserOperationClaimsDal
    {
    }
}
