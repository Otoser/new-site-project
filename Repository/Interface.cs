using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcogolDomain;

namespace AlcogolRepository
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        void Save();
        void Delete(T entity);
        void Add(T entity);
        void Update();
    }
}
