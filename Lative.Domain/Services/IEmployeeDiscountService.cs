using Lative.Domain.Entities;
using System.Threading.Tasks;

namespace Lative.Domain.Services
{
    public interface IEmployeeDiscountService
    {
        Task<decimal> GetEmployeeDiscountAsync(decimal amount, int userId);
    }
}
