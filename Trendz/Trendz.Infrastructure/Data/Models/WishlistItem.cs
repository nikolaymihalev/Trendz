using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Wishlist Item entity")]
    public class WishlistItem
    {
        [Comment("Item identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Wishlist identifier")]
        [Required]
        public int WishlistId { get; set; }

        [Comment("Product identifier")]
        public int ProductId { get; set; }

        [Comment("Date the item was added")]
        [Required]
        public DateTime DateAdded { get; set; }

        [ForeignKey(nameof(WishlistId))]
        public Wishlist Wishlist { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}