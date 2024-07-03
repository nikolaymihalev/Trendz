namespace Trendz.Core.Models.Payment
{
    /// <summary>
    /// Model for Payment information
    /// </summary>
    public class PaymentInfoModel
    {
        /// <summary>
        /// Payment identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Payment amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
