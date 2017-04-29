using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;
using System.Data.Entity;
namespace AlcogolRepository
{
    public class BasketRepository : BaseRepository<BasketEntity>, IBaseRepository<BasketEntity>
    {
        public BasketRepository(DbContext context) : base(context)
        {
        }
    }
}
