using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Order
{
    /// <summary>
    /// Model for Order Item
    /// </summary>
    public class OrderItemModel
    {
        /// <summary>
        /// Item identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int OrderId { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int ProductId { get; set; }

        /// <summary>
        /// Item quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Item unit price
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public decimal UnitPrice { get; set; }
    }
}
