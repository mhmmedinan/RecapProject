using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();

            //ColorTest();

            //CarTest();

            CarDtoDetails();

            Console.ReadLine();

        }

        private static void CarDtoDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Name + "/" + car.BrandName + "/" + car.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 4, Name = "Mercedes A180", DailyPrice = 1700, Description = "Sedan", ModelYear = "2015" });
            carManager.Add(new Car { BrandId = 2, ColorId = 1, Name = "Audi A4", DailyPrice = 1500, Description = "Hp", ModelYear = "2012" });
            ////carManager.Delete(new Car { Id = 1 });
            ////carManager.Update(new Car { Id = 2, BrandId = 3, ColorId = 2, Name = "BMW 320d", DailyPrice = 1000, Description = "Sports", ModelYear = "2017" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Name :  {0}  ModelYear : {1} Description :  {2} ", car.Name, car.ModelYear, car.Description);
            }
            var result = carManager.GetById(2);
            Console.WriteLine("Name : {0} , ModelYear : {1}", result.Name, result.ModelYear);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Blue" });
            colorManager.Add(new Color { ColorName = "White" });
            colorManager.Delete(new Color { Id = 3 });
            colorManager.Update(new Color { Id = 1, ColorName = "Red" });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            var result = colorManager.GetById(4);
            Console.WriteLine(result.ColorName);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Bmw" });
            brandManager.Add(new Brand { BrandName = "Audi" });
            brandManager.Delete(new Brand { Id = 2 });
            brandManager.Update(new Brand { Id = 1, BrandName = "Mercedes" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            var result = brandManager.GetById(1);
            Console.WriteLine(result.BrandName);
        }

    }
}
