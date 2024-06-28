using Trendz.Core.Models.Discount;

namespace Trendz.Core.Contracts
{
    public interface IDiscountService
    {
        Task<IEnumerable<DiscountInfoModel>> GetAllColorsAsync();
        Task AddAsync(DiscountFormModel model);
        Task DeleteAsync(int id);
        Task<DiscountInfoModel> GetByIdAsync(int id);
    }
}
