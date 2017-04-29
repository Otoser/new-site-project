using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;
using System.Data.Entity;
namespace AlcogolRepository
{
  
    public class ReviwesRepository : BaseRepository<ReviwesEntity>, IBaseRepository<ReviwesEntity>
    {
        public ReviwesRepository(DbContext context) : base(context)
        {
        }
    }
}
