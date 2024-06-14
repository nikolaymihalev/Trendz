using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Payment entity")]
    public class Payment
    {
        [Comment("Payment identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Order identifier")]
        [Required]
        public int OrderId { get; set; }

        [Comment("Payment date")]
        public DateTime PaymentDate { get; set; }

        [Comment("Payment amount")]
        [Required]
        public decimal Amount { get; set; }

        [Comment("Payment method")]
        [Required]
        public string PaymentMethod { get; set; } = string.Empty;

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;
    }
}
