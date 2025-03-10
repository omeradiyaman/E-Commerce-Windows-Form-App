using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistence.EntityConfigurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {

            builder
                .HasOne(x => x.Product)
                .WithMany(y => y.ProductCategories)
                .HasForeignKey(z => z.ProductId);
            builder
                .HasOne(x => x.Category)
                .WithMany(y => y.ProductCategories)
                .HasForeignKey(z => z.CategoryId);
        }
    }
}
