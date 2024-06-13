using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Cart Item entity")]
    public class CartItem
    {
        [Comment("Item identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Cart identifier")]
        [Required]
        public int CartId { get; set; }

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Item quantity")]
        public int Quantity { get; set; }

        [Comment("Date the item was added")]
        [Required]
        public DateTime DateAdded { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
