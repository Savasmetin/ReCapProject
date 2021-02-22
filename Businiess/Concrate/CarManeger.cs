using System;
using System.Collections.Generic;
using System.Text;
using Businiess.Abstract;
using DataAccesss.Abstract;
using Entities.Concrate;

namespace Businiess.Concrate
{
     public class CarManeger : ICarService
    {
        ICarDal _carDal;

        public CarManeger(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
