
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace prj.Helper.GenericRespository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T>  Add(T entity);
        void Delete(int id);

        void Delete(T entity);

        Task<T> Update(T entity);
         Task AddRange(IEnumerable<T> entities);

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);

        Task RemoveRange(IEnumerable<T> entities);
    }
}
