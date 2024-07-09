using Trendz.Core.Contracts;
using Trendz.Core.Models.Shipping;

namespace Trendz.Core.Services
{
    public class ShippingService : IShippingService
    {
        public Task AddAsync(ShippingFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(ShippingFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShippingInfoModel>> GetAllShippingsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShippingInfoModel>> GetAllShippingsForUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ShippingInfoModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
