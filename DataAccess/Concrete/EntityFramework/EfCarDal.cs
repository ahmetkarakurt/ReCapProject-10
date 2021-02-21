using Core.DataAccess.EntityFremework;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetails> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var Result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetails { BrandName = b.BrandName, CarName = c.Description, ColorName = r.ColorName, DailyPrice = c.DailyPrice };


                return Result.ToList();

            }
        }
    }
}
