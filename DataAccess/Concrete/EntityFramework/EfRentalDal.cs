using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cus in context.Customers
                             on r.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.Id

                             select new RentalDetailDto
                             {

                                 Id = r.Id,
                                 CarId = c.Id,
                                 UserName = us.FirstName + " " + us.LastName,
                                 CumpanyName = cus.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate

                             };

                    return result.ToList();
            }
        }
    }
}
