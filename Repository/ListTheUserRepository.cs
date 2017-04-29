using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;
using System.Data.Entity;
namespace AlcogolRepository
{
 
    public class ListTheUserRepository :BaseRepository<ListTheUserEntity>, IBaseRepository<ListTheUserEntity>
    {
        public ListTheUserRepository(DbContext context) : base(context)
        {
        }
    }
}
