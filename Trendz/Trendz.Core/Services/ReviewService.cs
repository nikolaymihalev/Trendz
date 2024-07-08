using Trendz.Core.Contracts;
using Trendz.Core.Models.Review;

namespace Trendz.Core.Services
{
    public class ReviewService : IReviewService
    {
        public Task AddAsync(ReviewFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(ReviewFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReviewInfoModel>> GetAllReviewsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReviewInfoModel>> GetAllReviewsForProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ReviewInfoModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
