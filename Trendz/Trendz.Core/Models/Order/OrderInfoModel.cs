namespace Trendz.Core.Models.Order
{
    /// <summary>
    /// Model for Order information
    /// </summary>
    public class OrderInfoModel
    {
        /// <summary>
        /// Order identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>        
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Order date
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Shipping date
        /// </summary>
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Order status
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Total amount of order
        /// </summary>
        public decimal TotalAmount { get; set; }        
    }
}
