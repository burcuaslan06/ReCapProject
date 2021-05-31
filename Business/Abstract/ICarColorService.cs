using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarColorService
    {
        List<CarColor> GetAll();
        void Add(CarColor carColor);
        void Delete(CarColor carColor);
        void Update(CarColor carColor);

    }
}
