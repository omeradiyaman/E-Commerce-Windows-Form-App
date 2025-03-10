using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Enums
{
    public enum ShipmentStatus
    {
        Pending = 1,
        Shipped,
        InTransit,
        OutForDelivery,
        Delivered,
        Returned
    }
}
