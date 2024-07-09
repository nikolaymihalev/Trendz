using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Shipping;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IRepository repository;

        public ShippingService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(ShippingFormModel model)
        {
            var entity = new Shipping()
            {
                OrderId = model.OrderId,
                ShippingAddress = model.ShippingAddress,
                City = model.City,
                PostalCode = model.PostalCode,
                State = model.State,
                Country = model.Country,
                ShippingDate = model.ShippingDate,
                DeliveryDate = model.DeliveryDate,
            };

            try
            {
                await repository.AddAsync<Shipping>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Shipping>(id);

            if (entity != null)
                await repository.DeleteAsync<Shipping>(id);
        }

        public async Task EditAsync(ShippingFormModel model)
        {
            var entity = await repository.GetByIdAsync<Shipping>(model.Id);

            if (entity != null)
            {
                entity.OrderId = model.OrderId;
                entity.ShippingAddress = model.ShippingAddress;
                entity.City = model.City;
                entity.PostalCode = model.PostalCode;
                entity.State = model.State;
                entity.Country = model.Country;
                entity.ShippingDate = model.ShippingDate;
                entity.DeliveryDate = model.DeliveryDate;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ShippingInfoModel>> GetAllShippingsAsync()
        {
            return await repository.AllReadonly<Shipping>()
                .Select(x => new ShippingInfoModel()
                {
                    Id = x.Id,
                    OrderId = x.OrderId,
                    ShippingAddress = x.ShippingAddress,
                    City = x.City,
                    PostalCode = x.PostalCode,
                    State = x.State,
                    Country = x.Country,
                    ShippingDate = x.ShippingDate,
                    DeliveryDate = x.DeliveryDate,
                })
                .ToListAsync();
        }

        public async Task<ShippingInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Shipping>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new ShippingInfoModel()
            {
                Id = entity.Id,
                OrderId = entity.OrderId,
                ShippingAddress = entity.ShippingAddress,
                City = entity.City,
                PostalCode = entity.PostalCode,
                State = entity.State,
                Country = entity.Country,
                ShippingDate = entity.ShippingDate,
                DeliveryDate = entity.DeliveryDate,
            };
        }
    }
}
