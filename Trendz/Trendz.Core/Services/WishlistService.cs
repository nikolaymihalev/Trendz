using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Wishlist;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class WishlistService : IWishlistService
    {
        private readonly IRepository repository;

        public WishlistService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(WishlistModel model)
        {
            var entity = new Wishlist()
            {
                UserId = model.UserId,
                DateCreated = DateTime.Now,
            };

            try
            {
                await repository.AddAsync<Wishlist>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task AddItemAsync(WishlistItemModel model)
        {
            var entity = new WishlistItem()
            {
                ProductId = model.ProductId,
                WishlistId = model.WishlistId,
                DateAdded = DateTime.Now,
            };

            try
            {
                await repository.AddAsync<WishlistItem>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Wishlist>(id);

            if (entity != null)
                await repository.DeleteAsync<Wishlist>(id);
        }

        public async Task<IEnumerable<WishlistModel>> GetAllWishlistsAsync()
        {
            return await repository.AllReadonly<Wishlist>()
                .Select(x => new WishlistModel()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    DateCreated = x.DateCreated
                })
                .ToListAsync();
        }

        public async Task<WishlistModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Wishlist>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new WishlistModel()
            {
                Id = entity.Id,
                UserId= entity.UserId,
                DateCreated = entity.DateCreated,
            };
        }

        public async Task<WishlistModel> GetByUserIdAsync(string userId)
        {
            var entity = await repository.AllReadonly<Wishlist>()
                .FirstOrDefaultAsync(x=>x.UserId==userId);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new WishlistModel()
            {
                Id = entity.Id,
                UserId = entity.UserId,
                DateCreated = entity.DateCreated,
            };
        }

        public async Task RemoveItemAsync(int id)
        {
            var entity = await repository.GetByIdAsync<WishlistItem>(id);

            if (entity != null)
                await repository.DeleteAsync<WishlistItem>(id);
        }
    }
}