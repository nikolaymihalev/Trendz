namespace Trendz.Core.Models.Product
{
    /// <summary>
    /// Model for information about user favorite product
    /// </summary>
    public class FavoriteProductModel
    {
        /// <summary>
        /// Favorite product identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Product model
        /// </summary>
        public ProductInfoModel Product { get; set; }
    }
}
