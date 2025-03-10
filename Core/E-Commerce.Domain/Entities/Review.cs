using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public Rating Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
