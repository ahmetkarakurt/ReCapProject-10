using Core.Utilities.Results.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(User user);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
