using E_Commerce.Domain.Entities;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Name).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(x => x.Surname).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(25);
            modelBuilder.Entity<User>().Property(x => x.PhoneNumber).HasMaxLength(11);
            modelBuilder.Entity<Category>().Property(x => x.Name).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(x => x.Address).HasMaxLength(100);


            //modelBuilder.Entity<ProductOrder>()
            //    .HasKey(pc => new { pc.OrderId, pc.ProductId });
            //modelBuilder.Entity<ProductOrder>()
            //    .HasOne(x => x.Product)
            //    .WithMany(y => y.ProductOrders)
            //    .HasForeignKey(z => z.ProductId);

            //modelBuilder.Entity<ProductOrder>()
            //    .HasOne(x => x.Order)
            //    .WithMany(y => y.ProductOrders)
            //    .HasForeignKey(z => z.OrderId);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });
            modelBuilder.Entity<ProductCategory>()
                .HasOne(x => x.Product)
                .WithMany(y => y.ProductCategories)
                .HasForeignKey(z => z.ProductId);
            modelBuilder.Entity<ProductCategory>()
                .HasOne(x => x.Category)
                .WithMany(y => y.ProductCategories)
                .HasForeignKey(z => z.CategoryId);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
