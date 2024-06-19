using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var data = new SeedData();

            builder.Property(p => p.Price)
                .HasPrecision(14, 2);

            builder.HasData(data.BlackTshirt);            
        }
    }
}
