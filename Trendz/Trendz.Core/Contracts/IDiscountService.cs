using Trendz.Core.Models.Discount;

namespace Trendz.Core.Contracts
{
    public interface IDiscountService
    {
        Task<IEnumerable<DiscountInfoModel>> GetAllDiscountsAsync();
        Task<IEnumerable<DiscountInfoModel>> GetDiscountsPerPercentageAsync(decimal percentage);
        Task<IEnumerable<CouponModel>> GetAllCouponsAsync();
        Task<IEnumerable<CouponModel>> GetNewestCouponsAsync(int count);
        Task AddAsync(DiscountFormModel model);
        Task DeleteAsync(int id);
        Task<DiscountInfoModel> GetByIdAsync(int id);
        Task<DiscountInfoModel?> GetProductDiscountAsync(int productId);
    }
}
