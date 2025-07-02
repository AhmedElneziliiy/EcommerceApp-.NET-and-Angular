using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecom.Infrastructure.Data.Config
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.Price).HasColumnType("decimal(18,2)");
            builder.HasData(
                new { Id = 1, Name = "labtop", Description = "Devices and gadgets" ,CategoryId=1,Price = 12.13m}
             );

        }
    }
}
