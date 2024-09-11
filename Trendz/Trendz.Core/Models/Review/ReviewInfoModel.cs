namespace Trendz.Core.Models.Review
{
    /// <summary>
    /// Model for Review information
    /// </summary>
    public class ReviewInfoModel
    {
        /// <summary>
        /// Review identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Rating identifier
        /// </summary>
        public int RatingId { get; set; }

        /// <summary>
        /// User comment
        /// </summary>
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// Date the review was published
        /// </summary>
        public DateTime PublishDate { get; set; }
    }
}
