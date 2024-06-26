using Trendz.Core.Models.Color;

namespace Trendz.Core.Contracts
{
    public interface IColorService
    {
        Task<IEnumerable<ColorInfoModel>> GetAllColorsAsync();
        Task AddAsync(ColorFormModel model);
        Task EditAsync(ColorFormModel model);
        Task DeleteAsync(int id);
        Task<ColorInfoModel> GetByIdAsync(int id);
    }
}
