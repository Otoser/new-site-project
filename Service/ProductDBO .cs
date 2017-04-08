using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class ProductDBO
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Excerpt { get; set; }
        public int Discount { get; set; }
        public int Amount { get; set; }
        //public virtual List<Reviews> Reviews { get; set; }
        //public virtual List<Branches> Branches { get; set; }
        //public virtual List<Manufacturer> Manufacturer { get; set; }
        public int AverageRating { get; set; }
    }
}
