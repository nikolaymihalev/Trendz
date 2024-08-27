using Trendz.Core.Models.Cart;

namespace Trendz.Core.Contracts
{
    public interface ICartService
    {
        Task<IEnumerable<CartModel>> GetAllCartsAsync();
        Task AddAsync(CartModel model);
        Task DeleteAsync(int id);
        Task<CartModel> GetByIdAsync(int id);
        Task<CartModel> GetByUserIdAsync(string userId);
        Task AddItemAsync(CartItemModel model);
        Task RemoveItemAsync(int id);
    }
}
