using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _Color;

        public InMemoryColorDal()
        {
            _Color = new List<Color> { 
            new Color{ColorId=1,ColorName="Renk 1" },
                 new Color{ColorId=2,ColorName="Renk 2" },
                      new Color{ColorId=3,ColorName="Renk 3" },
                           new Color{ColorId=4,ColorName="Renk 4" },
            };
        }
        public void Add(Entitiy.Concrete.Color color)
        {
            _Color.Add(color);
        }

        public void Delete(Entitiy.Concrete.Color color)
        {
            Color colordelete = _Color.SingleOrDefault(c => c.ColorId == color.ColorId);

            _Color.Remove(colordelete);

        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Entitiy.Concrete.Color> GetAll()
        {
            return _Color;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Entitiy.Concrete.Color GetById(Entitiy.Concrete.Color color)
        {
            return _Color.SingleOrDefault(c => c.ColorId == color.ColorId);
        }

        public void Update(Entitiy.Concrete.Color color)
        {
            Color colorupdate = _Color.SingleOrDefault(c => c.ColorId == color.ColorId);

            colorupdate.ColorId = color.ColorId;
            colorupdate.ColorName = color.ColorName;

            
        }
    }
}
