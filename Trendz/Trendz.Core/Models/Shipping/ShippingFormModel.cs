using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Shipping
{
    /// <summary>
    /// Model for adding or editing Shipping
    /// </summary>
    public class ShippingFormModel
    {
        /// <summary>
        /// Shipping identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int OrderId { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string ShippingAddress { get; set; } = string.Empty;

        /// <summary>
        /// The city from the address
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// The state from the address
        /// </summary>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// The postal code from the city
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string PostalCode { get; set; } = string.Empty;

        /// <summary>
        /// The country from the address
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Shipping date
        /// </summary>
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Delivery date
        /// </summary>
        public DateTime DeliveryDate { get; set; }
    }
}
