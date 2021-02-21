using Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concrete
{
   public   class Brand:IEntity

    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }
    }
}
