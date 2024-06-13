using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Category entity")]
    public class Category
    {
        [Comment("Category identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Category name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Comment("Date the category was added")]
        [Required]
        public DateTime DateAdded { get; set; }
    }
}
