using E_Commerce.Application.Interfaces.ProductInterfaces;
using E_Commerce.Domain.Entities;
using E_Commerce.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistence.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceContext _context;

        public ProductRepository(ECommerceContext context)
        {
            _context = context;
        }

        public Task<List<Product>> GetLast3Products()
        {
            throw new NotImplementedException();

        }

        public Task<List<Product>> GetTop3ProductUnder250()
        {
            throw new NotImplementedException();

        }

        public async Task<List<Product>> GetTop3RatedProducts()
        {
            var values = await _context.Products.Where(x => x.Price < 250).OrderBy(x => x.Price).Take(3).ToListAsync();
            return values;
        }
    }
}
