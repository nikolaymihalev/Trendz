using Trendz.Core.Models.Size;

namespace Trendz.Core.Contracts
{
    public interface ISizeService
    {
        Task<IEnumerable<SizeInfoModel>> GetAllColorsAsync();
        Task AddAsync(SizeFormModel model);
        Task EditAsync(SizeFormModel model);
        Task DeleteAsync(int id);
        Task<SizeInfoModel> GetByIdAsync(int id);
    }
}
