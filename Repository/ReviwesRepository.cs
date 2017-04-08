using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domens;
using System.Data.Entity;
namespace Repository
{
    public interface IReviwesRepository
    {
        IQueryable<Reviwes> GetAll();
        void Save();
        void Delete(Reviwes entity);
        void Add(Reviwes entity);
        void Update();
    }
    public class ReviwesRepository : IReviwesRepository
    {
        private readonly DbSet<Reviwes> _entities;
        private readonly DbContext _context;
        public ReviwesRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<Reviwes>();
        }
        public IQueryable<Reviwes> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(Reviwes entity)
        {
            _entities.Remove(entity);
        }
        public void Add(Reviwes entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
