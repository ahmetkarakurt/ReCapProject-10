using Core.Utilities.Results.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IColorService
    {
        IDataResult<List<Color>> GetAll();

        IDataResult<Color> GetById(Color color);


        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);

    }
}
