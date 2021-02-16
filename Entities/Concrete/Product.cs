using System;
using System.Collections.Generic;
using System.Text;

using Entities.Abstract;

namespace Entities.Concrete
{
   public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string BrandId { get; set; }
        public string ColorId { get; set; }
        public int ModelYear { get; set; }
        public short DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
