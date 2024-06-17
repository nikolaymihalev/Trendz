using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Product Color mapping entity")]
    public class ProductColor
    {
        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Color identifier")]
        [Required]
        public int ColorId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(ColorId))]
        public Color Color { get; set; } = null!;
    }
}
