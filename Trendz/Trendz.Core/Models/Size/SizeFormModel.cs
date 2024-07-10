using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendz.Infrastructure.Constants;

namespace Trendz.Core.Models.Size
{
    /// <summary>
    /// Model for adding or editing Size
    /// </summary>
    public class SizeFormModel
    {
        /// <summary>
        /// Size identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Size name
        /// </summary>
        [Required(ErrorMessage = ErrorMessageConstants.RequireErrorMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
