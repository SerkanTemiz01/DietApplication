using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AbstractRepository
{
    public interface IBaseRepository<T> where T : class, IBaseEntity
    {
        bool Add(T entity);
        bool AddRange(List<T> entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
        int Save();
    }
}
