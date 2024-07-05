namespace Trendz.Core.Models.Product
{
    /// <summary>
    /// Model for Product Image information
    /// </summary>
    public class ProductImageInfoModel
    {
        /// <summary>
        /// Image identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Image file
        /// </summary>
        public string Image { get; set; } = string.Empty;
    }
}
