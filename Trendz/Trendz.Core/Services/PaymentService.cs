using Microsoft.EntityFrameworkCore;
using Trendz.Core.Contracts;
using Trendz.Core.Models.Category;
using Trendz.Core.Models.Payment;
using Trendz.Infrastructure.Common;
using Trendz.Infrastructure.Constants;
using Trendz.Infrastructure.Data.Models;

namespace Trendz.Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IRepository repository;

        public PaymentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(PaymentFormModel model)
        {
            var entity = new Payment()
            {
                OrderId = model.OrderId,
                PaymentDate = model.PaymentDate,
                Amount = model.Amount,
                PaymentMethod = model.PaymentMethod,
            };

            try
            {
                await repository.AddAsync<Payment>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessageConstants.InvalidModelErrorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Payment>(id);

            if (entity != null)
                await repository.DeleteAsync<Payment>(id);
        }

        public async Task EditAsync(PaymentFormModel model)
        {
            var entity = await repository.GetByIdAsync<Payment>(model.Id);

            if (entity != null)
            {
                entity.OrderId = model.OrderId;
                entity.PaymentDate = model.PaymentDate;
                entity.Amount = model.Amount;
                entity.PaymentMethod = model.PaymentMethod;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<PaymentInfoModel>> GetAllPaymentsAsync()
        {
            return await repository.AllReadonly<Payment>()
                .Select(x => new PaymentInfoModel()
                {
                    Id = x.Id,
                    OrderId = x.OrderId,
                    PaymentDate = x.PaymentDate,
                    Amount = x.Amount,
                    PaymentMethod = x.PaymentMethod,
                })
                .ToListAsync();
        }

        public async Task<PaymentInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Payment>(id);

            if (entity == null)
            {
                throw new ArgumentNullException(ErrorMessageConstants.DoesntExistErrorMessage);
            }

            return new PaymentInfoModel()
            {
                Id = entity.Id,
                OrderId = entity.OrderId,
                PaymentDate = entity.PaymentDate,
                Amount = entity.Amount,
                PaymentMethod = entity.PaymentMethod
            };
        }
    }
}
