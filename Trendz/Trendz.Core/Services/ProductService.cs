using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Product;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(ProductFormModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                CategoryId = model.CategoryId,
                BrandId = model.BrandId,
                StockQuantity = model.StockQuantity,
                DateAdded = DateTime.Now,
            };

            try
            {
                await repository.AddAsync<Product>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task AddColorAsync(ProductColorModel model)
        {
            var entity = new ProductColor()
            {
                ProductId = model.ProductId,
                ColorId = model.ColorId
            };

            try
            {
                await repository.AddAsync<ProductColor>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Product>(id);

            if (entity != null)
                await repository.DeleteAsync<Product>(id);
        }

        public async Task EditAsync(ProductFormModel model)
        {
            var entity = await repository.GetByIdAsync<Product>(model.Id);

            if (entity != null)
            {
                entity.Name = model.Name;
                entity.Description = model.Description;
                entity.Price = model.Price;
                entity.CategoryId = model.CategoryId;
                entity.BrandId = model.BrandId;
                entity.StockQuantity = model.StockQuantity;
                entity.DateAdded = model.DateAdded;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ProductInfoModel>> GetAllProductsAsync()
        {
            return await repository.AllReadonly<Product>()
                .Select(x => new ProductInfoModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    CategoryId = x.CategoryId,
                    BrandId = x.BrandId,
                    StockQuantity = x.StockQuantity,
                    DateAdded = x.DateAdded,
                })
                .ToListAsync();
        }

        public async Task<ProductInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Product>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new ProductInfoModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                CategoryId = entity.CategoryId,
                BrandId = entity.BrandId,
                StockQuantity = entity.StockQuantity,
                DateAdded = entity.DateAdded,
            };
        }

        public async Task RemoveColorAsync(int productId, int colorId)
        {
            var entity = await repository.AllReadonly<ProductColor>()
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.ColorId == colorId);

            if (entity != null)
                repository.Delete<ProductColor>(entity);
        }
    }
}