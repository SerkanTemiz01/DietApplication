using DataAccess.AbstractRepository;
using DataAccess.Context;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly DietQueryDBContext _dietQueryDBContext;
        private DbSet<T> _table;
            public BaseRepository(DietQueryDBContext dietQueryDBContext)
        {
            _dietQueryDBContext = dietQueryDBContext;
            _table = _dietQueryDBContext.Set<T>();
        }
       
        public bool Add(T entity)
        {
            _table.Add(entity);
            return Save() > 0;
        }

        public bool AddRange(List<T> entity)
        {
            _table.AddRange(entity);
            return Save() > 0;
        }

        public bool Delete(T entity)
        {
            entity.Status = Status.Deleted;
            return Update(entity);
        }

        public List<T> GetAll()
        {
            return _table.Where(x => x.Status == Status.Active || x.Status == Status.Modified).ToList();
        }

        public T GetById(int id)
        {
            return _table.Find(id);
        }

        public int Save()
        {
            return _dietQueryDBContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _dietQueryDBContext.Entry<T>(entity).State = EntityState.Modified;
            return Save() > 0;
        }
    }
}
