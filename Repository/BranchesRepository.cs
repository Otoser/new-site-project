using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;
using System.Data.Entity;
namespace AlcogolRepository
{
  
    public class BranchesRepository : BaseRepository<BranchesEntity>, IBaseRepository<BranchesEntity>
    {
        public BranchesRepository(DbContext context) : base(context)
        {
        }
    }
}
