using Lative.Domain.Enums;
using Lative.Services.Calculators.EmployeeTypeCalculators.Interfaces;

namespace Lative.Services.Calculators.EmployeeTypeCalculators
{
    public class ContractorDiscountCalculator : IEmployeeTypeDiscountCalculator
    {
        public static EmployeeType EmployeeType => EmployeeType.Contractor;

        public decimal CalculateDiscount(decimal amount, int yearsServed)
        {
            return 0M;
        }
    }
}
