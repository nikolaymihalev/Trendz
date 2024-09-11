using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            var data = new SeedData();

            builder.HasOne(x => x.Rating).WithMany(x => x.Reviews).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(data.FiveStarReview);
        }
    }
}
