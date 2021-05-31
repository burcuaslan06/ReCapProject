using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetail.Description + " -- " + carDetail.BrandName +" ---"+ carDetail.ColorName + " ---" + carDetail.DailyPrice);
            }

        }

        private static void CarTest()
        {
            Car car = new Car { BrandId = 1, ColorId = 1, DailyPrice = 10, Description = "2.Kiralık araç", ModelYear = "2021" };
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
            foreach (var cars in carManager.GetAll())

            {
                Console.WriteLine("BrandId = " + cars.BrandId + " ColorId = " + cars.ColorId + " ModelYear = " + cars.ModelYear + " DailyPrice = " + cars.DailyPrice + " Description = " + cars.Description);
            }
        }
    }

    //9.GÜN DE KALDIM
}
