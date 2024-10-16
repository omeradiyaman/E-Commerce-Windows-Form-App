using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistence.EntityConfigurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(a=> new { a.OrderId, a.ProductId });

            builder.HasOne(x => x.Order)
                   .WithMany(y => y.OrderDetails)
                   .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Product)
                   .WithMany(y => y.OrderDetails)
                   .HasForeignKey(z => z.ProductId);
        }
    }
}
