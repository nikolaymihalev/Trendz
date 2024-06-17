using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Product image entity")]
    public class ProductImage
    {
        [Comment("Image identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Image file")]
        [Required]
        public byte[] Image { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
