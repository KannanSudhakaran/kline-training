using Microsoft.EntityFrameworkCore;
using ShoppingApp.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.EFRepositories
{
    public class EFGenericReposiotry<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public EFGenericReposiotry(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async virtual Task<T> Add(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task Delete(int id)
        {
            T entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            //  return entity;
        }

        public async virtual Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync<T>();
        }

        public async virtual Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async virtual Task Update(T item)
        {
            _context.Entry<T>(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            //  return item;
        }
    }

}
