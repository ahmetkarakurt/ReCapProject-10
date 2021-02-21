using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            foreach (var item in _rentalDal.GetAll(r=>r.CarId==rental.CarId))
            {
                if (item.ReturnDate==null)
                {
                    Console.WriteLine("Araba Henüz Teslim Edilmedi");
                    return new ErrorResult();
                }
            }
            if (rental.RentDate<=rental.RentDate)
            {
                Console.WriteLine("Kiralama Tarihi Teslim Tarihinden Büyük Olamaz");
                return new ErrorResult();
            }
            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(Rental rental)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c=>c.Id==rental.Id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
