namespace Trendz.Core.Models.Color
{
    /// <summary>
    /// Model for Color information
    /// </summary>
    public class ColorInfoModel
    {
        /// <summary>
        /// Color identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Color name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Color hexvalue
        /// </summary>
        public string HexValue { get; set; } = string.Empty;
    }
}
