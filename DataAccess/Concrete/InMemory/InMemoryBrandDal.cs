using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _Brand;

        public InMemoryBrandDal()
        {
            _Brand = new List<Brand> { 
            
            new Brand{BrandId=1,BrandName="Marka 1" },
              new Brand{BrandId=2,BrandName="Marka 2" },
                new Brand{BrandId=3,BrandName="Marka 3" },
                  new Brand{BrandId=4,BrandName="Marka 4" },
                    new Brand{BrandId=5,BrandName="Marka 5" },
                      new Brand{BrandId=6,BrandName="Marka 6" },

            };
        }

        public void Add(Brand brand)
        {
            _Brand.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandDelete = _Brand.SingleOrDefault(b=>b.BrandId==brand.BrandId);

            _Brand.Remove(brandDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _Brand;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand GetById(Brand brand)
        {
           return _Brand.SingleOrDefault(b => b.BrandId == brand.BrandId);
        }

        public void Update(Brand brand)
        {
            Brand brandUpdate = _Brand.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandUpdate.BrandId = brand.BrandId;
            brandUpdate.BrandName = brand.BrandName;
        }
    }
}
