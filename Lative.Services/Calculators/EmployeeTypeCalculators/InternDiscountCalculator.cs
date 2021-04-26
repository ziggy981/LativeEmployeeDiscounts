using Lative.Domain.Enums;
using Lative.Services.Calculators.EmployeeTypeCalculators.Interfaces;

namespace Lative.Services.Calculators.EmployeeTypeCalculators
{
    public class InternDiscountCalculator : IEmployeeTypeDiscountCalculator
    {
        public static EmployeeType EmployeeType => EmployeeType.Intern;

        public decimal CalculateDiscount(decimal amount, int yearsServed)
        {
            decimal discountPercent = 0M;

            if (amount > 30)
                discountPercent = 5M;

            return (amount * (discountPercent / 100));
        }
    }
}
