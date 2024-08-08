using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Coupon entity")]
    public class Coupon
    {
        [Comment("Coupon identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Coupon percentage")]
        [Required]
        public decimal Percentage { get; set; }

        [Comment("Coupon image file")]
        [Required]
        [Column(TypeName = "varbinary(MAX)")]
        public byte[] Image { get; set; } = null!;
    }
}
