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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental { CarId = 1, CustomerId = 2 };
            var result = rentalManager.Add(rental);
            Console.WriteLine(result.Message);

            //CarTest();

            //CarTest2();
           
            // UserTest();

            //CustomerTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { Id = 3, CompanyName = "Kodlama.io", UserId = 2 };
            var result = customerManager.Delete(customer);
            Console.WriteLine(result.Message);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User {Id=2005, FirstName = "Çağla", LastName = "Aslan", Email = "cagla.a@gmail.com", PasswordHash = "123" };
            var result = userManager.Delete(user);
            Console.WriteLine(result.Message);
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var carDetail in result.Data)
                {
                    Console.WriteLine(carDetail.Description + " -- " + carDetail.BrandName + " ---" + carDetail.ColorName + " ---" + carDetail.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        /*
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
*/
    }

    //9.GÜN DE KALDIM
}
