using Lative.Domain.Enums;
using Lative.Services.Calculators.EmployeeTypeCalculators.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace Lative.Services.Calculators.EmployeeTypeCalculators.Factories
{
    public static class EmployeeTypeDiscountCalculatorFactory
    {
        public static IEmployeeTypeDiscountCalculator Instantiate(EmployeeType employeeType)
        {
            Type typeImplemented = typeof(IEmployeeTypeDiscountCalculator);

            var selectedType = Assembly.GetExecutingAssembly()
                                    .GetTypes()
                                    .Where(t => typeImplemented.IsAssignableFrom(t))
                                    .SingleOrDefault(t => ((EmployeeType)t.GetTypeInfo()
                                                        .DeclaredProperties
                                                        .First(o => o.Name == nameof(EmployeeType))
                                                        .GetValue(null, null)) == employeeType);

            return (IEmployeeTypeDiscountCalculator)Activator.CreateInstance(selectedType);
        }
    }
}
