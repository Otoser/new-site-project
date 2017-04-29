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
        void Save();
        void Delete(Products entity);
        void Add(Products entity);
        void Update();
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
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(Products entity)
        {
            _entities.Remove(entity);
        }
        public void Add(Products entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
           _context.SaveChanges();
        }
    }
}
