using E_Commerce.Domain.Entities;
using E_Commerce.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistence.Context
{
    public class ECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MAHSUN;initial Catalog=ECommerceDb;integrated security=true;TrustServerCertificate=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration<Admin>(new AdminConfiguration());
           modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
           modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
           modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
           modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
           modelBuilder.ApplyConfiguration<OrderDetail>(new OrderDetailConfiguration());
           base.OnModelCreating(modelBuilder);
            
        }
    }
}
