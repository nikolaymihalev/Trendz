namespace Trendz.Core.Models.Wishlist
{
    /// <summary>
    /// Model for Wishlist
    /// </summary>
    public class WishlistModel
    {
        /// <summary>
        /// Wishlist identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Date the wishlist was created
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
