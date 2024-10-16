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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.Property(x => x.Surname).HasMaxLength(20);
            builder.Property(x => x.Password).HasMaxLength(25);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11);
            builder.Property(x => x.Address).HasMaxLength(100);
        }
    }
}
