using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarColorDal : ICarColorDal
    {
        public void Add(CarColor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarColor entity)
        {
            throw new NotImplementedException();
        }

        public CarColor Get(Expression<Func<CarColor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarColor> GetAll(Expression<Func<CarColor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CarColor entity)
        {
            throw new NotImplementedException();
        }
    }
}
