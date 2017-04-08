using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domens;
using System.Data.Entity;
namespace Repository
{
    public interface IManufacturerRepository
    {
        IQueryable<Manufacturer> GetAll();
        void Save();
        void Delete(Manufacturer entity);
        void Add(Manufacturer entity);
        void Update();
    }
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly DbSet<Manufacturer> _entities;
        private readonly DbContext _context;
        public ManufacturerRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<Manufacturer>();
        }
        public IQueryable<Manufacturer> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(Manufacturer entity)
        {
            _entities.Remove(entity);
        }
        public void Add(Manufacturer entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
