using System.Collections.Generic;
using System.Linq;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : OnkoSoftBase
    {
        void Save(T obj);

        void Delete(T obj);

        void DeleteAll();

        void Refresh(T obj);

        T GetById(object objId);

        IList<T> GetByBusinessKey(IDictionary<string, object> businessKeys);

        IQueryable<TEntity> ToList<TEntity>();
    }
}