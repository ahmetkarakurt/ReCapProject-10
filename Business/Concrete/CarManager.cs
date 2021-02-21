using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;

        }

        public IResult add(Car car)
        {

            if (car.Description.Length >= 2 && car.DailyPrice > 0)
                _CarDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            _CarDal.Delete(car);
            return new SuccessResult(Messages.ProductDelted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll());
        }

        public IDataResult<Car> GetById(Car car)
        {
            return new SuccessDataResult<Car>(_CarDal.Get(b => b.Id == car.Id));
        }

        public IDataResult<List<CarDetails>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetails>>(_CarDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _CarDal.Update(car);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
