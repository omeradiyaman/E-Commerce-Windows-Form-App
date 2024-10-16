using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<T> Add(T entity);
        void Update(T entity);
        void Delete(int id);
        int SaveChanges();
    }
}
