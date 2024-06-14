using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Discount entity")]
    public class Discount
    {
        [Comment("Discount identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Discount percentage")]
        [Required]
        public decimal DiscountPercentage { get; set; }

        [Comment("Discount start date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Comment("Discount end date")]
        [Required]
        public DateTime EndDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
