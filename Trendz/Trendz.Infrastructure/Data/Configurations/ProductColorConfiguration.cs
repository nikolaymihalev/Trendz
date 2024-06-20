using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class ProductColorConfiguration : IEntityTypeConfiguration<ProductColor>
    {
        public void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            var data = new SeedData();

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductColors)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(x => new { x.ProductId, x.ColorId });

            builder.HasData(new ProductColor[] { data.ProductColorBlack, data.ProductColorWhite });
        }
    }
}
