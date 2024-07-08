using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Review
{
    /// <summary>
    /// Model for adding or editing Review
    /// </summary>
    public class ReviewFormModel
    {
        /// <summary>
        /// Review identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int ProductId { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Review rating
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int Rating { get; set; }

        /// <summary>
        /// User comment
        /// </summary>
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// Date the review was published
        /// </summary>
        public DateTime PublishDate { get; set; }
    }
}
