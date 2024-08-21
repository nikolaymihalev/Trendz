using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Trendz.Infrastructure.Constants;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Product entity")]
    public class Product
    {
        [Comment("Product identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product name")]
        [MaxLength(ValidationConstants.ProductNameMaxLength)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Comment("Product description")]
        [MaxLength(ValidationConstants.ProductDescriptionMaxLength)]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Comment("Product price")]
        [Required]
        public decimal Price { get; set; }

        [Comment("Category identifier")]
        [Required]
        public int CategoryId { get; set; }

        [Comment("Brand identifier")]
        [Required]
        public int BrandId { get; set; }

        [Comment("Product quantity")]
        public int StockQuantity { get; set; }

        [Comment("Date the product was added")]
        [Required]
        public DateTime DateAdded { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
        public ICollection<Discount> Discounts { get; set; } = new List<Discount>();
        public ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
        public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public ICollection<ProductColor> ProductColors { get; set; } = new List<ProductColor>();
        public ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    }
}