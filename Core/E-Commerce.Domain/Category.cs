using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
