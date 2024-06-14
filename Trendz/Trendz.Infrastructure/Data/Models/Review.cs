﻿using Microsoft.AspNetCore.Identity;
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
        public string UserId { get; set; } = string.Empty;

        [Comment("Review rating")]
        [Required]
        public int Rating { get; set; }

        [Comment("User comment")]
        public string Comment { get; set; } = string.Empty;

        [Comment("Date the review was published")]
        [Required]
        public DateTime PublishDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}
