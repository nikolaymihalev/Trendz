using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Inventory
{
    /// <summary>
    /// Model for Inventory
    /// </summary>
    public class InventoryModel
    {
        /// <summary>
        /// Inventory identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int ProductId { get; set; }

        /// <summary>
        /// Product quantity in stock
        /// </summary>
        public int QuantityInStock { get; set; }

        /// <summary>
        /// Inventory warehouse location
        /// </summary>
        public string WarehouseLocation { get; set; } = string.Empty;
    }
}
