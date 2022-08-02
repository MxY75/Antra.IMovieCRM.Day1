using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieCRM.Infrastructure.Repository
{
   public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class

    {
        IMovieCrmDBContext db;
        public BaseRepositoryAsync(IMovieCrmDBContext _context) {
            db = _context;
        }

        public async Task<int> Delete(int id)
        {
            var entity =await db.Set<T>().FindAsync(id);
            db.Set<T>().Remove(entity);
            return await db.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<T>> GelAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            await db.Set<T>().AddAsync(entity);
            return await db.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            return await db.SaveChangesAsync();
        }
    }
}
