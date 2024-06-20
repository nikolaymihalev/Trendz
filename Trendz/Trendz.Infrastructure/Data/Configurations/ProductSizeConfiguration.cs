using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class ProductSizeConfiguration : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            var data = new SeedData();

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductSizes)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(x => new { x.ProductId, x.SizeId });

            builder.HasData(new ProductSize[] { data.ProductSizeM, data.ProductSizeS });
        }
    }
}
