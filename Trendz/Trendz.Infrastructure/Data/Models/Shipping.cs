using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Shipping entity")]
    public class Shipping
    {
        [Comment("Shipping identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Order identifier")]
        [Required]
        public int OrderId { get; set; }

        [Comment("Shipping address")]
        [Required]
        public string ShippingAddress { get; set; } = string.Empty;

        [Comment("The city from the address")]
        [Required]
        public string City { get; set; } = string.Empty;

        [Comment("The state from the address")]
        public string State { get; set; } = string.Empty;

        [Comment("The postal code from the city")]
        [Required]
        public string PostalCode { get; set; } = string.Empty;

        [Comment("The country from the address")]
        [Required]
        public string Country { get; set; } = string.Empty;

        [Comment("Shipping date")]
        [Required]
        public DateTime ShippingDate { get; set; }

        [Comment("Delivery date")]
        [Required]
        public DateTime DeliveryDate { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;
    }
}
