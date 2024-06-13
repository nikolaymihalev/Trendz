using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Order entity")]
    public class Order
    {
        [Comment("Order identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("User identifier")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [Comment("Order date")]
        [Required]
        public DateTime OrderDate { get; set; }

        [Comment("Shipping date")]
        [Required]
        public DateTime ShippingDate { get; set; }

        [Comment("Order status")]
        public string Status { get; set; } = string.Empty;

        [Comment("Total amount of order")]
        [Required]
        public decimal TotalAmount { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
