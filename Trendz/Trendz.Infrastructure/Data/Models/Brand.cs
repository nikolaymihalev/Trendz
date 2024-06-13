﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Brand entity")]
    public class Brand
    {
        [Comment("Brand identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Brand name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Comment("Date the brand was added")]
        [Required]
        public DateTime DateAdded { get; set; }
    }
}
