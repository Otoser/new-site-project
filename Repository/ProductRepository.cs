using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;
using System.Data.Entity;
namespace AlcogolRepository
{
  
    public class ProductRepository : BaseRepository<ProductsEntity>, IBaseRepository<ProductsEntity>
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }
    }
}
