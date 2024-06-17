using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Color entity")]
    public class Color
    {
        [Comment("Color identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Color name")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Comment("Color hexvalue")]
        [Required]
        public string HexValue { get; set; } = string.Empty;
    }
}
