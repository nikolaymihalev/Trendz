using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Size;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class SizeService : ISizeService
    {
        private readonly IRepository repository;

        public SizeService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(SizeFormModel model)
        {
            var entity = new Size()
            {
                Name = model.Name
            };

            try
            {
                await repository.AddAsync<Size>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Size>(id);

            if (entity != null)
                await repository.DeleteAsync<Size>(id);
        }

        public async Task EditAsync(SizeFormModel model)
        {
            var entity = await repository.GetByIdAsync<Size>(model.Id);

            if (entity != null)
            {
                entity.Name = model.Name;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<SizeInfoModel>> GetAllSizesAsync()
        {
            return await repository.AllReadonly<Size>()
                .Select(x => new SizeInfoModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .ToListAsync();
        }

        public async Task<SizeInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Size>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new SizeInfoModel()
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }
    }
}