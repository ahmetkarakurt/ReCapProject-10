using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _Car;

        public InMemoryCarDal()
        {
            _Car = new List<Car> { 
            
                new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=1250,ModelYear=2020,Description="Haftalık Fiyatı"},
                new Car {Id=2,BrandId=1,ColorId=1,DailyPrice=6000,ModelYear=2020,Description="Aylık Fiyatı"},
                new Car {Id=3,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=2020,Description="Günlük Fiyatı"},
                new Car {Id=4,BrandId=2,ColorId=2,DailyPrice=6000,ModelYear=2020,Description="Aylık Fiyatı"},
                new Car {Id=5,BrandId=2,ColorId=3,DailyPrice=6000,ModelYear=2020,Description="Aylık Fiyatı"},
                new Car {Id=6,BrandId=1,ColorId=3,DailyPrice=6000,ModelYear=2020,Description="Aylık Fiyatı"},
                new Car {Id=7,BrandId=4,ColorId=3,DailyPrice=100,ModelYear=2020,Description="Haftalık Fiyatı"},
                new Car {Id=8,BrandId=1,ColorId=1,DailyPrice=101,ModelYear=2020,Description="Haftalık Fiyatı"},
                new Car {Id=9,BrandId=2,ColorId=5,DailyPrice=3000,ModelYear=2020,Description="Aylık Fiyatı"},
                new Car {Id=10,BrandId=1,ColorId=3,DailyPrice=1000,ModelYear=2020,Description="Haftalık Fiyatı"},

            };
        }
        public void Add(Car car)
        {
            _Car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _Car.SingleOrDefault(c => c.Id == car.Id);

            _Car.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _Car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car getById(Car car)
        {
          return _Car.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<CarDetails> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _Car.SingleOrDefault(c => c.Id == car.Id);

            carUpdate.Id = car.Id;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            

        }
    }
}
