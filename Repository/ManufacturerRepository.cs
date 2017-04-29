using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;
using System.Data.Entity;
namespace AlcogolRepository
{
 
    public class ManufacturerRepository : BaseRepository<ManufacturerEntity>, IBaseRepository<ManufacturerEntity>
    {
        public ManufacturerRepository(DbContext context) : base(context)
        {
        }
    }
}
