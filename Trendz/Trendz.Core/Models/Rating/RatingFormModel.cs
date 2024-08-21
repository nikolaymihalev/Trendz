using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Rating
{
    /// <summary>
    /// Model for adding or editing Rating
    /// </summary>
    public class RatingFormModel
    {
        /// <summary>
        /// Rating identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Product identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int ProductId { get; set; }

        /// <summary>
        /// Rating value
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public double Value { get; set; }
    }
}
