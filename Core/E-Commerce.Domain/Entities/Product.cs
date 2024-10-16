using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public List<ProductCategory> ProductCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
