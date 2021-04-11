using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        List<UserRentalDto> GetUserRentalDto(Expression<Func<UserRentalDto, bool>> filter = null);
    }
}
