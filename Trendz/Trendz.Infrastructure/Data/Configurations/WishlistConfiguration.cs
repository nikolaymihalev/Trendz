using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class WishlistConfiguration : IEntityTypeConfiguration<Wishlist>
    {
        public void Configure(EntityTypeBuilder<Wishlist> builder)
        {
            var data = new SeedData();

            builder.HasData(data.Wishlist);
        }
    }
}
