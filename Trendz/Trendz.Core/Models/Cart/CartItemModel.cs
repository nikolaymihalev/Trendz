using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Cart
{
    /// <summary>
    /// Model for Cart item
    /// </summary>
    public class CartItemModel
    {
        /// <summary>
        /// Item identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Cart identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int CartId { get; set; }

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
        /// Date the item was added
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
