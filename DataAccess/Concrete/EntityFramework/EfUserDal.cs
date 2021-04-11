using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,CarContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<UserRentalDto> GetUserRentalDto(Expression<Func<UserRentalDto, bool>> filter = null)
        {
            using (var context = new CarContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.Id
                    join customer in context.Customers on rental.CustomerId equals customer.Id
                    join user in context.Users on customer.UserId equals user.Id
                    join brand in context.Brands on car.BrandId equals brand.Id

                    select new UserRentalDto()
                    {
                        Id = rental.Id,
                        CarId = car.Id,
                        UserId = user.Id,
                        BrandName = brand.BrandName,
                        ModelYear = car.ModelYear,
                        CompanyName = customer.CompanyName,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate,
                        Description = car.Description
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
           
        }
    }
}
