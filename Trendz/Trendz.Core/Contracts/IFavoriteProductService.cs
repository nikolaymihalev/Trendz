﻿using Trendz.Core.Models.Product;

namespace Trendz.Core.Contracts
{
    public interface IFavoriteProductService
    {
        Task AddAsync(FavoriteProductModel model);
        Task DeleteAsync(int id);
        Task<IEnumerable<FavoriteProductModel>> GetUserFavoriteProductsAsync(string userId);
        Task<bool> IsFavoriteProductExistsAsync(int productId, string userId);
        Task<FavoriteProductModel?> GetFavoriteProductAsync(int productId, string userId);
        Task<int> GetUserFavoriteProductsCountAsync(string userId);
    }
}
