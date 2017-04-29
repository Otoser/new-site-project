using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domens;
using System.Data.Entity;
namespace Repository
{
    public interface IBranchesRepository
    {
        IQueryable<Branches> GetAll();
        void Save();
        void Delete(Branches entity);
        void Add(Branches entity);
        void Update();
    }
    public class BranchesRepository : IBranchesRepository
    {
        private readonly DbSet<Branches> _entities;
        private readonly DbContext _context;
        public BranchesRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<Branches>();
        }
        public IQueryable<Branches> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(Branches entity)
        {
            _entities.Remove(entity);
        }
        public void Add(Branches entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
