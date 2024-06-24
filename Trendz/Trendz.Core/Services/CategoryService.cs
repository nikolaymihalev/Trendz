using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Category;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;

        public CategoryService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(CategoryFormModel model)
        {
            var entity = new Category()
            {
                Name = model.Name,
                DateAdded = DateTime.Now,
            };

            try
            {
                await repository.AddAsync<Category>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Category>(id);

            if (entity != null)
                await repository.DeleteAsync<Category>(id);
        }

        public async Task EditAsync(CategoryFormModel model)
        {
            var entity = await repository.GetByIdAsync<Category>(model.Id);

            if (entity != null)
            {
                entity.Name = model.Name;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CategoryInfoModel>> GetAllCategoriesAsync()
        {
            return await repository.AllReadonly<Category>()
                .Select(c => new CategoryInfoModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    DateAdded = c.DateAdded
                })
                .ToListAsync();
        }

        public async Task<CategoryInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Category>(id);

            if (entity == null) 
            {
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);
            }

            return new CategoryInfoModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                DateAdded = entity.DateAdded
            };
        }
    }
}
