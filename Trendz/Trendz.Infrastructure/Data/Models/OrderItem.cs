using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Order Item entity")]
    public class OrderItem
    {
        [Comment("Item identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Order identifier")]
        [Required]
        public int OrderId { get; set; }

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Item quantity")]
        public int Quantity { get; set; }

        [Comment("Item unit price")]
        [Required]
        public decimal UnitPrice { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
