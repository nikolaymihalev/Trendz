using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Order;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repository;

        public OrderService(IRepository _repositor)
        {
            repository = _repositor;
        }

        public async Task AddAsync(OrderFormModel model)
        {
            var entity = new Order()
            {
                UserId = model.UserId,
                OrderDate = model.OrderDate,
                ShippingDate = model.ShippingDate,
                Status = model.Status,
                TotalAmount = model.TotalAmount,
            };

            try
            {
                await repository.AddAsync<Order>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task AddItemAsync(OrderItemModel model)
        {
            var entity = new OrderItem()
            {
                OrderId = model.OrderId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                UnitPrice = model.UnitPrice,
            };

            try
            {
                await repository.AddAsync<OrderItem>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Order>(id);

            if (entity != null)
                await repository.DeleteAsync<Order>(id);
        }

        public async Task EditAsync(OrderFormModel model)
        {
            var entity = await repository.GetByIdAsync<Order>(model.Id);

            if (entity != null)
            {
                entity.OrderDate = model.OrderDate;
                entity.ShippingDate = model.ShippingDate;
                entity.Status = model.Status;
                entity.TotalAmount = model.TotalAmount;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<OrderInfoModel>> GetAllOrdersAsync()
        {
            return await repository.AllReadonly<Order>()
                .Select(x => new OrderInfoModel()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    OrderDate = x.OrderDate,
                    ShippingDate = x.ShippingDate,
                    Status = x.Status,
                    TotalAmount = x.TotalAmount,
                })
                .ToListAsync();
        }

        public async Task<OrderInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Order>(id);

            if (entity == null)
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);

            return new OrderInfoModel()
            {
                Id = entity.Id,
                UserId = entity.UserId,
                OrderDate = entity.OrderDate,
                ShippingDate = entity.ShippingDate,
                Status = entity.Status,
                TotalAmount = entity.TotalAmount,
            };
        }

        public async Task RemoveItemAsync(int id)
        {
            var entity = await repository.GetByIdAsync<OrderItem>(id);

            if (entity != null)
                await repository.DeleteAsync<OrderItem>(id);
        }
    }
}