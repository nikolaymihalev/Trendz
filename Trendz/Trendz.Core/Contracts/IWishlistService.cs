using Trendz.Core.Models.Wishlist;

namespace Trendz.Core.Contracts
{
    public interface IWishlistService
    {
        Task<IEnumerable<WishlistModel>> GetAllWishlistsAsync();
        Task AddAsync(WishlistModel model);
        Task DeleteAsync(int id);
        Task<WishlistModel> GetByIdAsync(int id);
        Task<WishlistModel> GetByUserIdAsync(string userId);
        Task AddItemAsync(WishlistItemModel model);
        Task RemoveItemAsync(int id);
    }
}
