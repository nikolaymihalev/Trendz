namespace Trendz.Core.Models.Shipping
{
    /// <summary>
    /// Model for Shipping information
    /// </summary>
    public class ShippingInfoModel
    {
        /// <summary>
        /// Shipping identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        public string ShippingAddress { get; set; } = string.Empty;

        /// <summary>
        /// The city from the address
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// The state from the address
        /// </summary>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// The postal code from the city
        /// </summary>
        public string PostalCode { get; set; } = string.Empty;

        /// <summary>
        /// The country from the address
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Shipping date
        /// </summary>
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Delivery date
        /// </summary>
        public DateTime DeliveryDate { get; set; }
    }
}
