using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Brand;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class BrandService : IBrandService
    {
        private readonly IRepository repository;

        public BrandService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(BrandFormModel model)
        {
            var entity = new Brand()
            {
                Name = model.Name,
                DateAdded = DateTime.Now 
            };

            try
            {
                await repository.AddAsync<Brand>(entity);   
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Brand>(id);

            if (entity != null)
                await repository.DeleteAsync<Brand>(id);
        }

        public async Task EditAsync(BrandFormModel model)
        {
            var entity = await repository.GetByIdAsync<Brand>(model.Id);

            if (entity != null) 
            {
                entity.Name = model.Name;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<BrandInfoModel>> GetAllBrandsAsync()
        {
            return await repository.AllReadonly<Brand>()
                .AsNoTracking()
                .Select(x => new BrandInfoModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    DateAdded = x.DateAdded,
                })
                .ToListAsync();
        }

        public async Task<BrandInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Brand>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new BrandInfoModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                DateAdded = entity.DateAdded
            };
        }
    }
}
