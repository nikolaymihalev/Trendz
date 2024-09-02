namespace Trendz.Core.Models.Product
{
    public class ProductQueryModel
    {
        public IEnumerable<ProductInfoModel> Products { get; set; } = new List<ProductInfoModel>();
        public string? Category { get; set; }
        public string? Sorting { get; set; }
        public double PagesCount { get; set; }
        public int CurrentPage { get; set; }
    }
}
