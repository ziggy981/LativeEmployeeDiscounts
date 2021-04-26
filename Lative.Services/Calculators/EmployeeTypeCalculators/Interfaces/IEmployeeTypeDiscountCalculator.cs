using Lative.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lative.Services.Calculators.EmployeeTypeCalculators.Interfaces
{
    public interface IEmployeeTypeDiscountCalculator
    {
        static EmployeeType EmployeeType { get; }

        decimal CalculateDiscount(decimal amount, int yearsServed);
    }
}
