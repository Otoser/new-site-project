using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domens
{
    public class Basket
    {
      //  public virtual List<Products> Products { get; set; }
        public string DeliveryMethod { get; set; }
        public string DeliveryTime { get; set; }
        public string WhereToDeliver { get; set; }
        public string TotalPrice { get; set; }
    }
}
