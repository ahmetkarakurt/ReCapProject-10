using Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.DTOs
{
    public class CarDetails:IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
