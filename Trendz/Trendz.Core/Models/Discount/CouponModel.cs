namespace Trendz.Core.Models.Discount
{
    public class CouponModel
    {
        /// <summary>
        /// Coupon identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Coupon percentage
        /// </summary>
        public decimal Percentage { get; set; }

        /// <summary>
        /// Coupon image file
        /// </summary>
        public string Image { get; set; } = string.Empty;
    }
}
