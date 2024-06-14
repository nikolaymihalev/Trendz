using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Inventory entity")]
    public class Inventory
    {
        [Comment("Inventory identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Product quantity in stock")]
        [Required]
        public int QuantityInStock { get; set; }

        [Comment("Inventory warehouse location")]
        public string WarehouseLocation { get; set; } = string.Empty;

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}