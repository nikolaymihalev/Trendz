using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Inventory;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IRepository repository;

        public InventoryService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(InventoryModel model)
        {
            var entity = new Inventory()
            {
                ProductId = model.ProductId,
                QuantityInStock = model.QuantityInStock,
                WarehouseLocation = model.WarehouseLocation,
            };

            try
            {
                await repository.AddAsync<Inventory>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Inventory>(id);

            if (entity != null)
                await repository.DeleteAsync<Inventory>(id);
        }

        public async Task EditAsync(InventoryModel model)
        {
            var entity = await repository.GetByIdAsync<Inventory>(model.Id);

            if (entity != null)
            {
                entity.ProductId = model.ProductId;
                entity.QuantityInStock = model.QuantityInStock;
                entity.WarehouseLocation = model.WarehouseLocation;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<InventoryModel>> GetAllInventoriesAsync()
        {
            return await repository.AllReadonly<Inventory>()
                .Select(x => new InventoryModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    QuantityInStock = x.QuantityInStock,
                    WarehouseLocation = x.WarehouseLocation,
                })
                .ToListAsync();
        }

        public async Task<InventoryModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Inventory>(id);

            if (entity == null)
            {
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);
            }

            return new InventoryModel()
            {
                Id = entity.Id,
                ProductId = entity.ProductId,
                QuantityInStock = entity.QuantityInStock,
                WarehouseLocation = entity.WarehouseLocation
            };
        }

        public async Task<int> GetProductQuantitytAsync(int productId, int sizeId)
        {
            var entity = await repository.AllReadonly<Inventory>()
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.SizeId == sizeId);

            if (entity != null)
                return entity.QuantityInStock;

            return 0;
        }
    }
}