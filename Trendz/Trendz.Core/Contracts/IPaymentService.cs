using Trendz.Core.Models.Payment;

namespace Trendz.Core.Contracts
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentInfoModel>> GetAllPaymentsAsync();
        Task AddAsync(PaymentFormModel model);
        Task EditAsync(PaymentFormModel model);
        Task DeleteAsync(int id);
        Task<PaymentInfoModel> GetByIdAsync(int id);
    }
}
