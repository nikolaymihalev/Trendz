using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            var data = new SeedData();

            builder.HasData(new Color[] { data.Black, data.White });
        }
    }
}
