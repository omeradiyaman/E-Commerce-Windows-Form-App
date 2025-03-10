using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int? StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderItem> OrderDetails { get; set; }
        public List<CartItem> CartItems { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<WishlistItem> WishlistItems { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
