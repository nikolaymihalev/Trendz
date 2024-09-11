using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Review entity")]
    public class Review
    {
        [Comment("Review identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product identifier")]
        [Required]
        public int ProductId { get; set; }

        [Comment("User identifier")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [Comment("Rating identifier")]
        [Required]
        public int RatingId { get; set; }

        [Comment("User comment")]
        public string Comment { get; set; } = string.Empty;

        [Comment("Date the review was published")]
        [Required]
        public DateTime PublishDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [ForeignKey(nameof(RatingId))]
        public Rating Rating { get; set; } = null!;
    }
}
