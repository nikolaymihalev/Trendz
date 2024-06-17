using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
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

            base.OnModelCreating(builder);
        }
    }
}
