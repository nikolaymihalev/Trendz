using Trendz.Core.Models.Shipping;

namespace Trendz.Core.Contracts
{
    public interface IShippingService
    {
        Task<IEnumerable<ShippingInfoModel>> GetAllShippingsAsync();
        Task<IEnumerable<ShippingInfoModel>> GetAllShippingsForUserAsync(string userId);
        Task AddAsync(ShippingFormModel model);
        Task EditAsync(ShippingFormModel model);
        Task DeleteAsync(int id);
        Task<ShippingInfoModel> GetByIdAsync(int id);
    }
}
