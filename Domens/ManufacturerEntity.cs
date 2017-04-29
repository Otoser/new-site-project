using System.Collections.Generic;
namespace AlcogolDomain
{
    public class ManufacturerEntity:BaseEntity
    {
        public string Name { get; set; }
        public virtual List<ProductsEntity> ProductsEntities { get; set; }
    }
}