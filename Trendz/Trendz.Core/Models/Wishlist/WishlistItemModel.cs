namespace Trendz.Core.Models.Wishlist
{
    /// <summary>
    /// Model for Wishlist Item
    /// </summary>
    public class WishlistItemModel
    {
        /// <summary>
        /// Item identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Wishlist identifier
        /// </summary>
        public int WishlistId { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Date the item was added
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
