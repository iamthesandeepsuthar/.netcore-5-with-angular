using prj.Helper.GenericRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Helper.UnitOfWork
{
   public interface IUnitOfWork: IDisposable
    {
      
        IRepository<T> Repository<T>() where T : class;
        int Save();
        Task<int> SaveAsync();
    }
}
