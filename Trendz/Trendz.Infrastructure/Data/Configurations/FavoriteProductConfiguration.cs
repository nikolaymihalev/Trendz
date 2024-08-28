using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class FavoriteProductConfiguration : IEntityTypeConfiguration<FavoriteProduct>
    {
        public void Configure(EntityTypeBuilder<FavoriteProduct> builder)
        {
            var data = new SeedData();

            builder.HasData(data.FavoriteProduct);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.FavoriteProducts)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
