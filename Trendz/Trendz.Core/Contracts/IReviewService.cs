using Trendz.Core.Models.Review;

namespace Trendz.Core.Contracts
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewInfoModel>> GetAllReviewsAsync();
        Task<IEnumerable<ReviewInfoModel>> GetAllReviewsForProductAsync(int id);
        Task AddAsync(ReviewFormModel model);
        Task EditAsync(ReviewFormModel model);
        Task DeleteAsync(int id);
        Task<ReviewInfoModel> GetByIdAsync(int id);
    }
}
