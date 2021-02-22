using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccesss.Abstract;
using Entities.Concrate;

namespace DataAccesss.Concrate.InMemory
{
     public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarName="wolsvagen", Id=1,BrandId=1,ColorId=1,ModelYear=2001,DailyPrice=40000,Description="möthüş bir araç"},
                new Car{CarName="toyota", Id=2,BrandId=1,ColorId=2,ModelYear=2010,DailyPrice=120000,Description="accık paalı"},
                new Car{CarName="honda", Id=3,BrandId=1,ColorId=3,ModelYear=2012,DailyPrice=140000,Description=" accık daha pahalı"},
                new Car{CarName="hundai", Id=4,BrandId=2,ColorId=3,ModelYear=2020,DailyPrice=4000000,Description="paran vars konuş"},
                new Car{CarName="tofaş", Id=5,BrandId=2,ColorId=3,ModelYear=2011,DailyPrice=401000,Description=" bu baba takımı alır ama  ucuz baba"},
                new Car{CarName="bmw", Id=6,BrandId=3,ColorId=4,ModelYear=1995,DailyPrice=10000,Description="tam fakır işi"},
                new Car{CarName="mercedes" , Id=7,BrandId=4,ColorId=5,ModelYear=1997,DailyPrice=3000,Description="baya ucuz benlik "},
                new Car{CarName="ford", Id=8,BrandId=4,ColorId=6,ModelYear=2017,DailyPrice=150000,Description="orta derece paalı"},
                new Car{CarName="mustag", Id=9,BrandId=5,ColorId=7,ModelYear=2016,DailyPrice=190000,Description="bu biraz daha pahalı"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
