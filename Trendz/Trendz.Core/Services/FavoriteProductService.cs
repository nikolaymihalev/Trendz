using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Product;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class FavoriteProductService : IFavoriteProductService
    {
        private readonly IRepository repository;

        public FavoriteProductService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(FavoriteProductModel model)
        {
            var entity = new FavoriteProduct()
            {
                ProductId = model.ProductId,
                UserId = model.UserId,
            };

            try
            {
                await repository.AddAsync<FavoriteProduct>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<FavoriteProduct>(id);

            if (entity != null)
            {
                await repository.DeleteAsync<FavoriteProduct>(id);
                await repository.SaveChangesAsync();
            }
        }

        public async Task<FavoriteProductModel?> GetFavoriteProductAsync(int productId, string userId)
        {
            var entity = await repository.AllReadonly<FavoriteProduct>()
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.UserId == userId);

            if (entity != null)
            {
                return new FavoriteProductModel()
                {
                    Id = entity.Id,
                    UserId = userId,
                    ProductId = productId,
                };
            }

            return null;
        }

        public async Task<IEnumerable<FavoriteProductModel>> GetUserFavoriteProductsAsync(string userId)
        {
            var list = await repository.AllReadonly<FavoriteProduct>()
                .Where(x => x.UserId == userId)
                .Select(x => new FavoriteProductModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    UserId = x.UserId,
                    Product = new ProductInfoModel() 
                    {
                        Id = x.ProductId,
                        Name = x.Product.Name,
                        Description = x.Product.Description,
                        Price = x.Product.Price,
                        CategoryId = x.Product.CategoryId,
                        BrandId = x.Product.BrandId,
                        StockQuantity = x.Product.StockQuantity,
                        DateAdded = x.Product.DateAdded,
                    }
                }).ToListAsync();

            return list;
        }

        public async Task<int> GetUserFavoriteProductsCountAsync(string userId)
        {
            return await repository.AllReadonly<FavoriteProduct>()
                .Where(x => x.UserId == userId)
                .CountAsync();
        }

        public async Task<bool> IsFavoriteProductExistsAsync(int productId, string userId)
        {
            var entity = await repository.AllReadonly<FavoriteProduct>()
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.UserId == userId);

            if (entity != null)
            {
                return true;
            }

            return false;
        }
    }
}
