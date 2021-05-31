using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarColorManager : ICarColorService
    {
        ICarColorDal _carColorDal;

        public CarColorManager(ICarColorDal carcolorDal)
        {
            _carColorDal = carcolorDal;
        }

        public void Add(CarColor carColor)
        {
            _carColorDal.Add(carColor);
            Console.WriteLine(carColor.ColorName + " rengi eklendi.");
        }

        public void Delete(CarColor carColor)
        {
            _carColorDal.Delete(carColor);
            Console.WriteLine(carColor.ColorName + " rengi silindi");
        }

        public List<CarColor> GetAll()
        {
            return _carColorDal.GetAll();
        }

        public void Update(CarColor carColor)
        {
            _carColorDal.Update(carColor);
            Console.WriteLine(carColor.ColorName + " rengi güncellendi.");
        }
    }
}
