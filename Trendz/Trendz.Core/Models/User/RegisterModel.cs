﻿using System.ComponentModel.DataAnnotations;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.User
{
    /// <summary>
    /// User profile model for register
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// User email
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        [EmailAddress]
        [StringLength(ValidationConstants.EmailMaxLength,
            MinimumLength = ValidationConstants.EmailMinLength,
            ErrorMessage = ErrorMessageConstants.StringLengthErrorMessage)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// User password
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.PasswordMaxLength,
            MinimumLength = ValidationConstants.PasswordMinLength,
            ErrorMessage = ErrorMessageConstants.StringLengthErrorMessage)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
