using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Product
{
    /// <summary>
    /// Model for adding or editing Product Image
    /// </summary>
    public class ProductImageFormModel
    {
        /// <summary>
        /// Image identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public int ProductId { get; set; }

        /// <summary>
        /// Image of the product
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public byte[] Image { get; set; } = new byte[128];

        /// <summary>
        /// Uploaded file for product image
        /// </summary>
        public IFormFile? ImageFile { get; set; }
    }
}
