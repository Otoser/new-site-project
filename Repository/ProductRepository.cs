using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domens;
using System.Data.Entity;
namespace Repository
{
    public interface IProductRepository
    {
        IQueryable<Products> GetAll();
    }
    public class ProductRepository : IProductRepository
    {
        private readonly DbSet<Products> _entities;
        private readonly DbContext _context;
        public ProductRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<Products>();
        }
        public IQueryable<Products> GetAll()
        {
            return _entities.AsQueryable();
        }
    }
}
