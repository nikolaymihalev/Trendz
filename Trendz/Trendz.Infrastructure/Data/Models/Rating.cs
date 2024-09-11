using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    public class Rating
    {
        [Key]
        [Comment("Rating identifier")]
        public int Id { get; set; }

        [Comment("User identifier")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Rating value")]
        [Required]
        public double Value { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}