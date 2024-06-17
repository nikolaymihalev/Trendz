using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Product Size mapping entity")]
    public class ProductSize
    {
        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Size identifier")]
        [Required]
        public int SizeId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(SizeId))]
        public Size Size { get; set; } = null!;
    }
}
