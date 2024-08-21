using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendz.Core.Models.Rating
{
    /// <summary>
    /// Model for Rating information
    /// </summary>
    public class RatingInfoModel
    {
        /// <summary>
        /// Rating identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Rating value
        /// </summary>
        public double Value { get; set; }
    }
}
