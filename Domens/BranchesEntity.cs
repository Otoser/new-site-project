using System.Collections.Generic;
namespace AlcogolDomain
{
    public class BranchesEntity:BaseEntity
    {
        public string DirectorName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public virtual List<ProductsEntity> ProductsEntities { get; set; }
    }
}
