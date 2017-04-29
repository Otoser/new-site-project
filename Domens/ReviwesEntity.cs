using System.Collections.Generic;
namespace AlcogolDomain
{
    public class ReviwesEntity:BaseEntity
    {
        public string Comment { get; set; }
        public virtual List<ProductsEntity> ProductsEntities { get; set; }
    }
}
