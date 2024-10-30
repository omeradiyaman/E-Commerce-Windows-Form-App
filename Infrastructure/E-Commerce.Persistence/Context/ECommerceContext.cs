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
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Shipment> Shipments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
           modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
           modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
           modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
           modelBuilder.ApplyConfiguration<OrderItem>(new OrderItemConfiguration());
           modelBuilder.ApplyConfiguration<WishlistItem>(new WishlistItemConfiguration());
           base.OnModelCreating(modelBuilder);
            
        }
    }
}
