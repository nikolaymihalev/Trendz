using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Discount;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IRepository repository;

        public DiscountService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(DiscountFormModel model)
        {
            var entity = new Discount()
            {
                ProductId = model.ProductId,
                DiscountPercentage = model.DiscountPercentage,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
            };

            try
            {
                await repository.AddAsync<Discount>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Discount>(id);

            if (entity != null)
                await repository.DeleteAsync<Discount>(id);
        }

        public async Task<IEnumerable<DiscountInfoModel>> GetAllColorsAsync()
        {
            return await repository.AllReadonly<Discount>()
                .Select(x => new DiscountInfoModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    DiscountPercentage = x.DiscountPercentage,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                })
                .ToListAsync();
        }

        public async Task<DiscountInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Discount>(id);

            if (entity == null)
            {
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);
            }

            return new DiscountInfoModel()
            {
                Id = entity.Id,
                ProductId = entity.ProductId,
                DiscountPercentage = entity.DiscountPercentage,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
            };
        }
    }
}