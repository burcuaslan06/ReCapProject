using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(CarColor carColor)
        {
            _carColorDal.Add(carColor);
            return new SuccessResult(Messages.CarColorAdded);
        }

        public IResult Delete(CarColor carColor)
        {
            _carColorDal.Delete(carColor);
            return new SuccessResult(Messages.CarColorDeleted);
        }

        public IDataResult<List<CarColor>> GetAll()
        {
            return new SuccessDataResult<List<CarColor>>(_carColorDal.GetAll(), Messages.CarColorListed);
        }

        public IResult Update(CarColor carColor)
        {
            _carColorDal.Update(carColor);
            return new SuccessResult(Messages.CarColorUpdated);
        }
    }
}
