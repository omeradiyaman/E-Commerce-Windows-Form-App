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
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int? UnitInStock { get; set; }
        public List<Category> Categories { get; set; }
        public int CategoryId { get; set; }
        public List<Wishlist> Wishlists { get; set; }
    }
}
