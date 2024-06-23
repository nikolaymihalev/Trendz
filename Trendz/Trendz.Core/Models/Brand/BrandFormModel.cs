using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Brand
{
    /// <summary>
    /// Model for creating or editing Brand
    /// </summary>
    public class BrandFormModel
    {
        /// <summary>
        /// Brand identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Brand name
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.NameMaxLength,
            MinimumLength = ValidationConstants.NameMinLength,
            ErrorMessage = ErrorMessageConstants.StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
