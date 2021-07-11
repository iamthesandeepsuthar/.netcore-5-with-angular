using prj.Data.Models;
using prj.Helper.GenericRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Helper.UnitOfWork
{
  public  class UnitOfWork:IUnitOfWork
    {
        private readonly dbJohnySinsContext _context = null;
        public UnitOfWork(dbJohnySinsContext context)
        {
            this._context = context;
        }
       
        public IRepository<T> Repository<T>() where T : class
        {
            return new Repository<T>(_context);
             
        }
        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
