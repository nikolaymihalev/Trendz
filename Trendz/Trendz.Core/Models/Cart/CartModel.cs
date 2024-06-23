namespace Trendz.Core.Models.Cart
{
    /// <summary>
    /// Model for User cart
    /// </summary>
    public class CartModel
    {
        /// <summary>
        /// Cart identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Date the cart was created
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
