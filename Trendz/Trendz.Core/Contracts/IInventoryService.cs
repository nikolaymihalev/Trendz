using Trendz.Core.Models.Inventory;

namespace Trendz.Core.Contracts
{
    public interface IInventoryService
    {
        Task<IEnumerable<InventoryModel>> GetAllInventoriesAsync();
        Task AddAsync(InventoryModel model);
        Task EditAsync(InventoryModel model);
        Task DeleteAsync(int id);
        Task<InventoryModel> GetByIdAsync(int id);
        Task<int> GetProductQuantitytAsync(int productId, int sizeId);
    }
}
