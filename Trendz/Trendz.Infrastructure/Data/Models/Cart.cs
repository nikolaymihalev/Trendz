using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Cart entity")]
    public class Cart
    {
        [Comment("Cart identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("User identifier")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [Comment("Date the cart was created")]
        [Required]
        public DateTime DateCreated { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
