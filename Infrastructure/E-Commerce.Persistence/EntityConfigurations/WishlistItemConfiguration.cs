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
    public class WishlistItemConfiguration : IEntityTypeConfiguration<WishlistItem>
    {
        public void Configure(EntityTypeBuilder<WishlistItem> builder)
        {
            builder.HasOne(x => x.Wishlist)
                   .WithMany(x => x.WhislistItems)
                   .HasForeignKey(x => x.WishlistId);
            builder.HasOne(x => x.Product)
                    .WithMany(x => x.WishlistItems)
                    .HasForeignKey(x => x.ProductId);
        }
    }
}
