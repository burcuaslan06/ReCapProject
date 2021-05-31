using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>

            {
                new Car{ Id=1, BrandId=10, ColorId=100, ModelYear="2018", DailyPrice=5000, Description ="Audio"},
                new Car{ Id=2, BrandId=20, ColorId=200, ModelYear="2019", DailyPrice=6000, Description ="BMW"},
                new Car{ Id=3, BrandId=30, ColorId=300, ModelYear="2020", DailyPrice=500, Description ="Mercedes"},
                new Car{ Id=4, BrandId=40, ColorId=400, ModelYear="2021", DailyPrice=1000, Description ="Ford"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;
        }
    }
}
