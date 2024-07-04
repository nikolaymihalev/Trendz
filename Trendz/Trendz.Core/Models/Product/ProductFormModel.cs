using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Product
{
    /// <summary>
    /// Model for adding or editing Product
    /// </summary>
    public class ProductFormModel
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        [StringLength(ValidationConstants.ProductNameMaxLength,
            MinimumLength = ValidationConstants.ProductNameMinLength,
            ErrorMessage = ErrorMessageConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product description
        /// </summary>
        [StringLength(ValidationConstants.ProductDescriptionMaxLength,
            MinimumLength = ValidationConstants.ProductDescriptionMinLength,
            ErrorMessage = ErrorMessageConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Product price
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public decimal Price { get; set; }

        /// <summary>
        /// Category identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Brand identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int BrandId { get; set; }

        /// <summary>
        /// Product quantity
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Date the product was added
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
