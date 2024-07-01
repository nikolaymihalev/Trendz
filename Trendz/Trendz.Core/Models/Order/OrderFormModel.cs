using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Order
{
    /// <summary>
    /// Model for adding and editing Order
    /// </summary>
    public class OrderFormModel
    {
        /// <summary>
        /// Order identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>        
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Order date
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Shipping date
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Order status
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Total amount of order
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public decimal TotalAmount { get; set; }
    }
}
