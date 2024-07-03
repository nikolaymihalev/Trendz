using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Payment
{
    /// <summary>
    /// Model for adding or editing Payment
    /// </summary>
    public class PaymentFormModel
    {
        /// <summary>
        /// Payment identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int OrderId { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Payment amount
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
