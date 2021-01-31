using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Update(new Car
            {
                Id = 2,
                BrandId = 2,
                ColorId = 7,
                Description = "M Sport"

            });

            carManager.Delete(new Car
            {
                Id = 1
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka    :  {0}", car.BrandId);
                Console.WriteLine("Renk     :  {0}", car.ColorId);
                Console.WriteLine("Model    :  {0}", car.ModelYear);
                Console.WriteLine("Açıklama :  {0}", car.Description);

                Console.WriteLine("---------------------------------");

            }





        }
    }
}
