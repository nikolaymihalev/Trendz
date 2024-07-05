using Trendz.Core.Models.Product;

namespace Trendz.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductInfoModel>> GetAllProductsAsync();
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
    }
}
