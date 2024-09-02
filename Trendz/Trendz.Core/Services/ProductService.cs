using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Product;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(ProductFormModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                CategoryId = model.CategoryId,
                BrandId = model.BrandId,
                StockQuantity = model.StockQuantity,
                DateAdded = DateTime.Now,
            };

            try
            {
                await repository.AddAsync<Product>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task AddColorAsync(ProductColorModel model)
        {
            var entity = new ProductColor()
            {
                ProductId = model.ProductId,
                ColorId = model.ColorId
            };

            try
            {
                await repository.AddAsync<ProductColor>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task AddImageAsync(ProductImageFormModel model)
        {
            var entity = new ProductImage()
            {
                ProductId = model.ProductId,
                Image = model.Image
            };

            try
            {
                await repository.AddAsync<ProductImage>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task AddSizeAsync(ProductSizeModel model)
        {
            var entity = new ProductSize()
            {
                ProductId = model.ProductId,
                SizeId = model.SizeId
            };

            try
            {
                await repository.AddAsync<ProductSize>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Product>(id);

            if (entity != null)
                await repository.DeleteAsync<Product>(id);
        }

        public async Task EditAsync(ProductFormModel model)
        {
            var entity = await repository.GetByIdAsync<Product>(model.Id);

            if (entity != null)
            {
                entity.Name = model.Name;
                entity.Description = model.Description;
                entity.Price = model.Price;
                entity.CategoryId = model.CategoryId;
                entity.BrandId = model.BrandId;
                entity.StockQuantity = model.StockQuantity;
                entity.DateAdded = model.DateAdded;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ProductColorModel>> GetAllColorsForProductAsync(int id)
        {
            return await repository.AllReadonly<ProductColor>()
                .Where(x=>x.ProductId==id)
                .Select(x => new ProductColorModel()
                {
                    ProductId = x.ProductId,
                    ColorId = x.ColorId
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductImageInfoModel>> GetAllImagesForProductAsync(int id)
        {
            return await repository.AllReadonly<ProductImage>()
                .Where(x => x.ProductId == id)
                .Select(x => new ProductImageInfoModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    Image = Convert.ToBase64String(x.Image)
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductInfoModel>> GetAllProductsAsync()
        {
            return await repository.AllReadonly<Product>()
                .Select(x => new ProductInfoModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    CategoryId = x.CategoryId,
                    BrandId = x.BrandId,
                    StockQuantity = x.StockQuantity,
                    DateAdded = x.DateAdded,
                    CategoryName = x.Category.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductSizeModel>> GetAllSizesForProductAsync(int id)
        {
            return await repository.AllReadonly<ProductSize>()
                .Where(x => x.ProductId == id)
                .Select(x => new ProductSizeModel()
                {
                    ProductId = x.ProductId,
                    SizeId = x.SizeId
                })
                .ToListAsync();
        }

        public async Task<ProductInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Product>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new ProductInfoModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                CategoryId = entity.CategoryId,
                BrandId = entity.BrandId,
                StockQuantity = entity.StockQuantity,
                DateAdded = entity.DateAdded,
                CategoryName = entity.Category.Name
            };
        }

        public async Task<ProductQueryModel> GetProductsForPageAsync(string? category = null, string? sorting = null, int currentPage = 1)
        {
            var model = new ProductQueryModel();

            int formula = (currentPage - 1) * ValidationConstants.MaxProductsPerPage;

            if (currentPage <= 1)
            {
                formula = 0;
            }

            model.Products = await GetAllProductsAsync();

            if (category != null)
            {
                if (category.ToLower() != "all")
                {
                    model.Products = model.Products
                        .Where(x => x.CategoryName.ToLower() == category.ToLower())
                        .ToList();
                    model.Category = category;
                }
            }

            if (sorting != null)
            {
                if (sorting.ToLower() == "newest")
                {
                    model.Products = model.Products.OrderByDescending(x => x.DateAdded).ToList();
                    model.Sorting = sorting;
                }
                else if (sorting.ToLower() == "oldest")
                {
                    model.Products = model.Products.OrderBy(x => x.DateAdded).ToList();
                    model.Sorting = sorting;
                }
            }
            model.PagesCount = Math.Ceiling((model.Products.Count() / Convert.ToDouble(ValidationConstants.MaxProductsPerPage)));

            model.Products = model.Products
                .Skip(formula)
                .Take(ValidationConstants.MaxProductsPerPage);

            model.CurrentPage = currentPage;

            return model;
        }

        public async Task<IEnumerable<ProductInfoModel>> GetProductsWithHighestRatingAsync(int count)
        {
            return await repository.AllReadonly<Rating>()
                .OrderByDescending(x => x.Value)
                .Select(x => new ProductInfoModel()
                {
                    Id = x.Product.Id,
                    Name = x.Product.Name,
                    Description = x.Product.Description,
                    Price = x.Product.Price,
                    CategoryId = x.Product.CategoryId,
                    BrandId = x.Product.BrandId,
                    StockQuantity = x.Product.StockQuantity,
                    DateAdded = x.Product.DateAdded,
                    CategoryName = x.Product.Category.Name
                })
                .Take(count)
                .ToListAsync();
        }

        public async Task RemoveColorAsync(int productId, int colorId)
        {
            var entity = await repository.AllReadonly<ProductColor>()
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.ColorId == colorId);

            if (entity != null)
                repository.Delete<ProductColor>(entity);
        }

        public async Task RemoveImageAsync(int id)
        {
            var entity = await repository.GetByIdAsync<ProductImage>(id);

            if (entity != null)
                await repository.DeleteAsync<ProductImage>(id);
        }

        public async Task RemoveSizeAsync(int productId, int sizeId)
        {
            var entity = await repository.AllReadonly<ProductSize>()
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.SizeId == sizeId);

            if (entity != null)
                repository.Delete<ProductSize>(entity);
        }
    }
}