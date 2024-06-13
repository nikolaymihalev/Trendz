using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Product entity")]
    public class Product
    {
        [Comment("Product identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product name")]
        [MaxLength(150)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Comment("Product description")]
        [MaxLength(1000)]
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
    }
}
