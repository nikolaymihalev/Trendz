using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trendz.Infrastructure.Data.Configurations;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<CartItem> CartItems { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Discount> Discounts { get; set; } = null!;
        public DbSet<Inventory> Inventories { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Shipping> Shippings { get; set; } = null!;
        public DbSet<Wishlist> Wishlists { get; set; } = null!;
        public DbSet<WishlistItem> WishlistItems { get; set; } = null!;
        public DbSet<Color> Colors { get; set; } = null!;
        public DbSet<Size> Sizes { get; set; } = null!;
        public DbSet<ProductImage> ProductImages { get; set; } = null!;
        public DbSet<ProductColor> ProductColors { get; set; } = null!;
        public DbSet<ProductSize> ProductSizes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new BrandConfiguration()); 
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CartConfiguration());

            builder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(14, 2);

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(14, 2);

            builder.Entity<OrderItem>()
                .Property(p => p.UnitPrice)
                .HasPrecision(14, 2);

            builder.Entity<Order>()
                .Property(p => p.TotalAmount)
                .HasPrecision(14, 2);

            builder.Entity<Discount>()
                .Property(p => p.DiscountPercentage)
                .HasPrecision(14, 2);

            builder.Entity<ProductColor>()
                .HasOne(x => x.Product)
                .WithMany(x => x.ProductColors)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ProductColor>()
               .HasKey(x => new { x.ProductId, x.ColorId });

            builder.Entity<ProductSize>()
                .HasOne(x => x.Product)
                .WithMany(x => x.ProductSizes)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ProductSize>()
              .HasKey(x => new { x.ProductId, x.SizeId });

            base.OnModelCreating(builder);
        }
    }
}
