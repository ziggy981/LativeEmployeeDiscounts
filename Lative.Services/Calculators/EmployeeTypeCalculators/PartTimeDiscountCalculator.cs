using Lative.Domain.Enums;
using Lative.Services.Calculators.EmployeeTypeCalculators.Interfaces;

namespace Lative.Services.Calculators.EmployeeTypeCalculators
{
    public class PartTimeDiscountCalculator : IEmployeeTypeDiscountCalculator
    {
        public static EmployeeType EmployeeType => EmployeeType.PartTime;

        public decimal CalculateDiscount(decimal amount, int yearsServed)
        {
            decimal discountPercent = 5M;

            if (yearsServed > 5)
                discountPercent += 3M;

            return (amount * (discountPercent / 100));
        }
    }
}
