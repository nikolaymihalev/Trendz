using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Color;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class ColorService : IColorService
    {
        private readonly IRepository repository;

        public ColorService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(ColorFormModel model)
        {
            var entity = new Color()
            {
                Name = model.Name,
                HexValue = model.HexValue
            };

            try
            {
                await repository.AddAsync<Color>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Color>(id);

            if (entity != null)
                await repository.DeleteAsync<Color>(id);
        }

        public async Task EditAsync(ColorFormModel model)
        {
            var entity = await repository.GetByIdAsync<Color>(model.Id);

            if (entity != null)
            {
                entity.Name = model.Name;
                entity.HexValue = model.HexValue;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ColorInfoModel>> GetAllColorsAsync()
        {
            return await repository.AllReadonly<Color>()
                .Select(x => new ColorInfoModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    HexValue = x.HexValue
                })
                .ToListAsync();
        }

        public async Task<ColorInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Color>(id);

            if (entity == null)
            {
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);
            }

            return new ColorInfoModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                HexValue = entity.HexValue
            };
        }
    }
}