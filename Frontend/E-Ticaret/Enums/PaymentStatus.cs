using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Enums
{
    public enum PaymentStatus
    {
        Completed = 1,
        Failed,
        Refunded,
        Cancelled
    }
}
