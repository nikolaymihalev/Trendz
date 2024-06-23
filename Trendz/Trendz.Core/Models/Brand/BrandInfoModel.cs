namespace Trendz.Core.Models.Brand
{
    /// <summary>
    /// Model for Brand information
    /// </summary>
    public class BrandInfoModel
    {
        /// <summary>
        /// Brand identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Brand name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Date the brand was added
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
