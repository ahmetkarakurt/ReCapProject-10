using Core.DataAcess;
using Entitiy.Concrete;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public  interface ICarDal:IEntityRepository<Car>
    {

        List<CarDetails> GetCarDetails();

    }
}
