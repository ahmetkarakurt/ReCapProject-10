using Core.Utilities.Results.Abstract;
using Entitiy.Concrete;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetById(Car car);

        IResult add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<CarDetails>> GetCarDetails();

    }
}
