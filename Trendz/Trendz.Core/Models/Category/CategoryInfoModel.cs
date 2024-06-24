namespace Trendz.Core.Models.Category
{
    /// <summary>
    /// Model for Category information 
    /// </summary>
    public class CategoryInfoModel
    {
        /// <summary>
        /// Category identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Date the category was added
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
