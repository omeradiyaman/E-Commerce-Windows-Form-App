using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public int OrderId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string TrackingNumber { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }
        public Order Order { get; set; }    
    }
}
