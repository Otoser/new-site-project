using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domens;
using System.Data.Entity;
namespace Repository
{
    public interface IListTheUserRepository
    {
        IQueryable<ListTheUser> GetAll();
        void Save();
        void Delete(ListTheUser entity);
        void Add(ListTheUser entity);
        void Update();
    }
    public class ListTheUserRepository : IListTheUserRepository
    {
        private readonly DbSet<ListTheUser> _entities;
        private readonly DbContext _context;
        public ListTheUserRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<ListTheUser>();
        }
        public IQueryable<ListTheUser> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(ListTheUser entity)
        {
            _entities.Remove(entity);
        }
        public void Add(ListTheUser entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
