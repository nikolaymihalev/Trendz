using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Color
{
    /// <summary>
    /// Model for adding or editting Color
    /// </summary>
    public class ColorFormModel
    {
        /// <summary>
        /// Color identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Color name
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Color hexvalue
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string HexValue { get; set; } = string.Empty;
    }
}
