using Core.Utilities.Results.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand>  GetById(Brand brand);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);

    }
}
