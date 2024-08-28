using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("User favorite product")]
    public class FavoriteProduct
    {
        [Comment("Favorite product identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("User identifier")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        public IdentityUser User { get; set; } = null!;
    }
}
