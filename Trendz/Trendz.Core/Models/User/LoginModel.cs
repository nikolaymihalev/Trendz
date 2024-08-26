using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.User
{
    /// <summary>
    /// User profile model for login
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// User email
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// User password
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
