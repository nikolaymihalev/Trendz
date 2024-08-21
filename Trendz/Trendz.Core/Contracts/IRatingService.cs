namespace Trendz.Core.Contracts
{
    public interface IRatingService
    {
        Task AddAsync(RatingFormModel model);
        Task DeleteAsync(int id);
        Task EditAsync(RatingFormModel model);
        Task<double> GetAverageRatingAboutProductAsync(int productId);
        Task<IEnumerable<RatingInfoModel>> GetAllRatingsAboutProductAsync(int productId);
    }
}
