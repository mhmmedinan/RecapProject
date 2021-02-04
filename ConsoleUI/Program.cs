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

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId=2,ColorId=4,Name="Bmw",DailyPrice=500,Description="Sports",ModelYear="2015" });
            carManager.GetAll();
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Name :  {0}  ModelYear : {1} Description :  {2} ", car.Name,car.ModelYear,car.Description);
            }

            Console.ReadLine();

        }
    }
}
