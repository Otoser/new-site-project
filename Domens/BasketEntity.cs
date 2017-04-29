using System.Collections.Generic;
namespace AlcogolDomain
{
    public class BasketEntity:BaseEntity
    {
        public string DeliveryMethod { get; set; }
        public string DeliveryTime { get; set; }
        public string WhereToDeliver { get; set; }
        public string TotalPrice { get; set; }
    }
}
