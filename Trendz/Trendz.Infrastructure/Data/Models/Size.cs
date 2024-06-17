using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trendz.Infrastructure.Data.Models
{
    [Comment("Size entity")]
    public class Size
    {
        [Comment("Size identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Size name")]
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();
    }
}
