using Microsoft.EntityFrameworkCore;
using prj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace prj.Helper.GenericRespository
{
    public class Repository<T> : IRepository<T>  where T:class
    {
        private readonly dbJohnySinsContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(dbJohnySinsContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

    

        public async Task<T> Get(int id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async  Task<T> Add(T entity)
        {
            await entities.AddAsync(entity);
         //  await this.context.SaveChangesAsync();

            return entity;
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        //     context.SaveChangesAsync();

        }

        public void Delete(int id)
        {
            T existing = entities.Find(id);
            entities.Remove(existing);
         //   context.SaveChangesAsync();

        }


        public async Task<T> Update(T entity)
        {
            
            try
            {
                entities.Update(entity);
            //    await context.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
           await context.Set<T>().AddRangeAsync(entities);
           
        //  await  context.SaveChangesAsync();

        }
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await entities.Where(expression).ToListAsync();
        }

        public async  Task RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        //   await context.SaveChangesAsync();

        }


    }
}
