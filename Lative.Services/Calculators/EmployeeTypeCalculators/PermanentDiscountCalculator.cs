using Lative.Domain.Enums;
using Lative.Services.Calculators.EmployeeTypeCalculators.Interfaces;

namespace Lative.Services.Calculators.EmployeeTypeCalculators
{
    public class PermanentDiscountCalculator : IEmployeeTypeDiscountCalculator
    {
        public static EmployeeType EmployeeType => EmployeeType.Permanent;

        public decimal CalculateDiscount(decimal amount, int yearsServed)
        {
            decimal discountPercent = 10M;

            if (yearsServed > 3)
                discountPercent += 5M;

            return (amount * (discountPercent / 100));
        }
    }
}
