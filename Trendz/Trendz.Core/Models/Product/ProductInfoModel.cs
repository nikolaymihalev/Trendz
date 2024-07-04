namespace Trendz.Core.Models.Product
{
    /// <summary>
    /// Model for Product information
    /// </summary>
    public class ProductInfoModel
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Product price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Category identifier
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Brand identifier
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// Product quantity
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Date the product was added
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
