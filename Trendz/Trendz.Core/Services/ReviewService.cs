using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Review;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository repository;

        public ReviewService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(ReviewFormModel model)
        {
            var entity = new Review()
            {
                ProductId = model.ProductId,
                UserId = model.UserId,
                Rating = model.Rating,
                Comment = model.Comment,
                PublishDate = model.PublishDate
            };

            try
            {
                await repository.AddAsync<Review>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Review>(id);

            if (entity != null)
                await repository.DeleteAsync<Review>(id);
        }

        public async Task EditAsync(ReviewFormModel model)
        {
            var entity = await repository.GetByIdAsync<Review>(model.Id);

            if (entity != null)
            {
                entity.ProductId = model.ProductId;
                entity.UserId = model.UserId;
                entity.Rating = model.Rating;
                entity.Comment = model.Comment;
                entity.PublishDate = model.PublishDate;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ReviewInfoModel>> GetAllReviewsAsync()
        {
            return await repository.AllReadonly<Review>()
                .Select(x => new ReviewInfoModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    UserId = x.UserId,
                    Rating = x.Rating,
                    Comment = x.Comment,
                    PublishDate = x.PublishDate
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ReviewInfoModel>> GetAllReviewsForProductAsync(int id)
        {
            return await repository.AllReadonly<Review>()
                .Where(x => x.ProductId == id)
                .Select(x => new ReviewInfoModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    UserId = x.UserId,
                    Rating = x.Rating,
                    Comment = x.Comment,
                    PublishDate = x.PublishDate
                })
                .ToListAsync();
        }

        public async Task<ReviewInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Review>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new ReviewInfoModel()
            {
                Id = entity.Id,
                ProductId = entity.ProductId,
                UserId = entity.UserId,
                Rating = entity.Rating,
                Comment = entity.Comment,
                PublishDate = entity.PublishDate
            };
        }

        public async Task<int> GetReviewsForProductCountAsync(int productId)
        {
            return await repository.AllReadonly<Review>()
                .Where(x => x.ProductId == productId)
                .CountAsync();
        }
    }
}