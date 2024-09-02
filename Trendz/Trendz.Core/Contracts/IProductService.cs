using Trendz.Core.Models.Product;

namespace Trendz.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductInfoModel>> GetAllProductsAsync();
        Task<IEnumerable<ProductInfoModel>> GetProductsWithHighestRatingAsync(int count);
        Task<ProductQueryModel> GetProductsForPageAsync(string? category = null, string? sorting = null, int currentPage = 1);
        Task AddAsync(ProductFormModel model);
        Task EditAsync(ProductFormModel model);
        Task DeleteAsync(int id);
        Task<ProductInfoModel> GetByIdAsync(int id);
        Task<IEnumerable<ProductColorModel>> GetAllColorsForProductAsync(int id);
        Task AddColorAsync(ProductColorModel model);
        Task RemoveColorAsync(int productId, int colorId);
        Task<IEnumerable<ProductImageInfoModel>> GetAllImagesForProductAsync(int id);
        Task AddImageAsync(ProductImageFormModel model);
        Task RemoveImageAsync(int id);
        Task<IEnumerable<ProductSizeModel>> GetAllSizesForProductAsync(int id);
        Task AddSizeAsync(ProductSizeModel model);
        Task RemoveSizeAsync(int productId, int sizeId);
    }
}
