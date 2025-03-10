using E_Commerce.Application.Interfaces;
using E_Commerce.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ECommerceContext _context;
        private readonly DbSet<T> _dbset;

        public Repository(ECommerceContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            _dbset.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbset.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var value = await _dbset.FindAsync(id);
            if (value == null)
            {
                throw new ArgumentException($"Bu {id}' li  kullanıcı bulunamadı.");
            }
            return await _dbset.FindAsync(id);
        }


        public async Task UpdateAsync(T entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
