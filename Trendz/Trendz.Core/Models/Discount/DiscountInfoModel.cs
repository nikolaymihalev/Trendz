namespace Trendz.Core.Models.Discount
{
    /// <summary>
    /// Model for Discount information
    /// </summary>
    public class DiscountInfoModel
    {
        /// <summary>
        /// Discount identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Discount percentage
        /// </summary>
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Discount start date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Discount end date
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
