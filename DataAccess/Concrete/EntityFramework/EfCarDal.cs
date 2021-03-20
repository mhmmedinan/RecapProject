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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        

       
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from car in context.Cars 
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join cl in context.Colors
                             on car.ColorId equals cl.Id
                            
                            

                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = b.Id,
                                 BrandName = b.BrandName,
                                 ColorId = cl.Id,
                                 ColorName = cl.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 ImagePath = (from im in context.CarImages where im.CarId==car.Id select im.ImagePath).FirstOrDefault(),
                                
                                
                                 
                                 


                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();





            }
        }

       
    }
}
