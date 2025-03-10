using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public OrderStatus OrderState { get; set; }
        public string ShippingAddress { get; set; }
        public decimal Amount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
