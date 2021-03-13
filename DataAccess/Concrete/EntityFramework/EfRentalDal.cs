using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Core.Entities.Concrete;
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
                var result = from rental in context.Rentals
                             join car in context.Cars
                                 on rental.CarId equals car.Id
                             join customer in context.Customers
                                 on rental.CustomerId equals customer.Id
                             join brand in context.Brands
                                 on car.BrandId equals brand.Id
                             join user in context.Users
                                 on customer.UserId equals user.Id


                             select new RentalDetailDto
                             {

                                 Id = rental.Id,
                                 BrandName = brand.BrandName,
                                 ModelYear = car.ModelYear,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CompanyName = customer.CompanyName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate

                             };

                return result.ToList();
            }
        }
    }
}
