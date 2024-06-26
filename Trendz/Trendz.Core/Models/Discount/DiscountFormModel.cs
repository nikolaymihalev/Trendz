using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Discount
{
    /// <summary>
    /// Model for adding or editing Discount
    /// </summary>
    public class DiscountFormModel
    {
        /// <summary>
        /// Discount identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int ProductId { get; set; }

        /// <summary>
        /// Discount percentage
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Discount start date
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Discount end date
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public DateTime EndDate { get; set; }
    }
}
