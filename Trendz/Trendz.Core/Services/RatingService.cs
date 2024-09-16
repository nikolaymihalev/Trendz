using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Rating;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRepository repository;
        private readonly UserManager<IdentityUser> userManager;

        public RatingService(
            IRepository _repository,
            UserManager<IdentityUser> _userManager)
        {
            repository = _repository;
            userManager = _userManager;
        }

        public async Task AddAsync(RatingFormModel model)
        {
            var entity = new Rating()
            {
                UserId = model.UserId,
                ProductId = model.ProductId,
                Value = model.Value,
            };

            try
            {
                await repository.AddAsync<Rating>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var rating = await repository
                .AllReadonly<Rating>()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (rating == null)
            {
                throw new ApplicationException(string.Format(ErrorMessageConstants.InvalidModelErrorMessage, "rating"));
            }

            await repository.DeleteAsync<Rating>(id);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(RatingFormModel model)
        {
            var allRatings = repository.AllReadonly<Rating>();

            var rating = allRatings.FirstOrDefault(x => x.UserId == model.UserId && x.ProductId == model.ProductId);

            if (rating == null)
            {
                throw new ApplicationException(string.Format(ErrorMessageConstants.InvalidModelErrorMessage, "rating"));
            }

            await DeleteAsync(rating.Id);
            await AddAsync(model);

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<RatingInfoModel>> GetAllRatingsAboutProductAsync(int productId)
        {
            return await repository.AllReadonly<Rating>()
                .Where(x => x.ProductId == productId)
                .Select(x => new RatingInfoModel()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    UserUsername = x.User.UserName,
                    ProductId = x.ProductId,
                    Value = x.Value
                })
                .ToListAsync();
        }

        public async Task<double> GetAverageRatingAboutProductAsync(int productId)
        {
            if (repository.AllReadonly<Rating>().Any(x => x.ProductId == productId))
            {
                return repository.AllReadonly<Rating>()
                    .Where(x => x.ProductId == productId)
                    .Average(x => x.Value);
            }

            return 0;
        }

        public async Task<RatingInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Rating>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            var user = await userManager.FindByIdAsync(entity.UserId);

            return new RatingInfoModel()
            {
                Id = id,
                UserId = entity.UserId,
                UserUsername = user.UserName,
                ProductId= entity.ProductId,
                Value = entity.Value
            };
        }
    }
}
