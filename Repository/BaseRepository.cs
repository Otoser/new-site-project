using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;
using System.Data.Entity;

namespace AlcogolRepository
{
    public abstract class BaseRepository<T>:IBaseRepository<T> where T:BaseEntity
    {
        private readonly DbSet<T> _entities;
        private readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }
        public void Add(T entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
