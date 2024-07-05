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
        Task AddColorAsync(ProductColorModel model);
        Task RemoveColorAsync(int productId, int colorId);
    }
}
