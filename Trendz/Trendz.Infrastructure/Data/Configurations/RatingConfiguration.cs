using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            var data = new SeedData();

            builder.HasData(data.FiveStar);
        }
    }
}
