using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Cart;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class CartService : ICartService
    {
        private readonly IRepository repository;

        public CartService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(CartModel model)
        {
            var entity = new Cart()
            {
                UserId = model.UserId,
                DateCreated = DateTime.Now,
            };

            try
            {
                await repository.AddAsync<Cart>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task AddItemAsync(CartItemModel model)
        {
            var entity = new CartItem()
            {
                CartId = model.CartId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                DateAdded = DateTime.Now,
            };

            try
            {
                await repository.AddAsync<CartItem>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Cart>(id);

            if (entity != null)
                await repository.DeleteAsync<Cart>(id);
        }

        public async Task<IEnumerable<CartModel>> GetAllCartsAsync()
        {
            return await repository.AllReadonly<Cart>()
                .Select(x => new CartModel()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    DateCreated = x.DateCreated,
                })
                .ToListAsync();
        }

        public async Task<CartModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Cart>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new CartModel()
            {
                Id = entity.Id,
                UserId = entity.UserId,
                DateCreated = entity.DateCreated,
            };
        }

        public async Task RemoveItemAsync(int id)
        {
            var entity = await repository.GetByIdAsync<CartItem>(id);

            if (entity != null)
                await repository.DeleteAsync<CartItem>(id);
        }
    }
}