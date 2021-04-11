using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = c.CompanyName,
                                 Findeks = c.Findeks

                             };
                return result.ToList();



            }
        }

        public List<CustomerDetailDto> GetCustomerUserId(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Customers
                    join u in context.Users
                        on c.UserId equals u.Id
                    select new CustomerDetailDto
                    {
                        Id = c.Id,
                        UserId = u.Id,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        CompanyName = c.CompanyName,
                       Findeks = c.Findeks
                        

                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();



            }
        }
    }
}
