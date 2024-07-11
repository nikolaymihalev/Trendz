using Trendz.Core.Contracts;
using Trendz.Core.Models.Wishlist;

namespace Trendz.Core.Services
{
    public class WishlistService : IWishlistService
    {
        public Task AddAsync(WishlistModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WishlistModel>> GetAllWishlistsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WishlistModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WishlistModel> GetByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
