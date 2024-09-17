using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data.Configurations
{
    internal class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            var data = new SeedData();

            builder.HasOne(x => x.Size).WithMany(x => x.Inventories).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Inventory[] { data.BlackTshirtSInStock, data.BlackTshirtMInStock });
        }
    }
}
