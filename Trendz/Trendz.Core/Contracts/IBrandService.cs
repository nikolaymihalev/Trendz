using Trendz.Core.Models.Brand;

namespace Trendz.Core.Contracts
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandInfoModel>> GetAllBrandsAsync();
        Task AddAsync(BrandFormModel model);
        Task EditAsync(BrandFormModel model);
        Task DeleteAsync(int id);
        Task<BrandInfoModel> GetByIdAsync(int id);
    }
}
