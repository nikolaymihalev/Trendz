using Trendz.Core.Models.Order;

namespace Trendz.Core.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderInfoModel>> GetAllOrdersAsync();
        Task AddAsync(OrderFormModel model);
        Task EditAsync(OrderFormModel model);
        Task DeleteAsync(int id);
        Task<OrderInfoModel> GetByIdAsync(int id);
    }
}
