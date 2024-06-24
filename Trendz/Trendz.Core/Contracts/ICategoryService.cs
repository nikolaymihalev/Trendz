using Trendz.Core.Models.Category;

namespace Trendz.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryInfoModel>> GetAllCategoriesAsync();
        Task AddAsync(CategoryFormModel model);
        Task EditAsync(CategoryFormModel model);
        Task DeleteAsync(int id);
        Task<CategoryInfoModel> GetByIdAsync(int id);
    }
}
