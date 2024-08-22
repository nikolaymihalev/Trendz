using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.Property(p => p.DiscountPercentage)
                .HasPrecision(14, 2);

            var data = new SeedData();

            builder.HasData(data.Discount20);
        }
    }
}
