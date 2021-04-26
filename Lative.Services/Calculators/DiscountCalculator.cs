using System;
using System.Threading.Tasks;
using Lative.Domain.Enums;
using Lative.Services.Calculators.EmployeeTypeCalculators.Factories;
using Lative.Services.Calculators.EmployeeTypeCalculators.Interfaces;

namespace Lative.Services.Calculators
{
    public class DiscountCalculator
    {
        private readonly IEmployeeTypeDiscountCalculator _employeeTypeCalculator;

        public DiscountCalculator(EmployeeType employeeType)
        {
            _employeeTypeCalculator = EmployeeTypeDiscountCalculatorFactory.Instantiate(employeeType);
        }

        public decimal Calculate(decimal amount, int yearsServed)
        {
            try
            {
                return _employeeTypeCalculator.CalculateDiscount(amount, yearsServed);
            }
            catch (Exception ex)
            {
                // Code to log the Error...

                throw;
            }
        }
    }
}

