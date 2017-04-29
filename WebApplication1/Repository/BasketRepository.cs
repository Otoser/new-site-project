using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domens;
using System.Data.Entity;
namespace Repository
{
    public interface IBasketRepository
    {
        IQueryable<Basket> GetAll();
        void Save();
        void Delete(Basket entity);
        void Add(Basket entity);
        void Update();
    }
    public  class BasketRepository : IBasketRepository
    {
        private readonly DbSet<Basket> _entities;
        private readonly DbContext _context;
        public BasketRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<Basket>();
        }
        public IQueryable<Basket> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(Basket entity)
        {
            _entities.Remove(entity);
        }
        public void Add(Basket entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
