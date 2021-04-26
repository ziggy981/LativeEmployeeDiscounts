using System;
using System.Threading.Tasks;
using Lative.Domain;
using Lative.Domain.Entities;
using Lative.Domain.Services;
using Lative.Persistence;
using Lative.Services.Calculators;

namespace Lative.Services
{
    public class EmployeeDiscountService : IEmployeeDiscountService
    {
        private IUnitOfWork _uow;

        public EmployeeDiscountService(string connectionString)
        {
            _uow = new UnitOfWork(connectionString);
        }

        public async Task<decimal> GetEmployeeDiscountAsync(decimal amount, int userId)
        {
            var employee = await _uow.Employees.GetByIdAsync(userId);

            if (employee == null)
                throw new Exception("Invalid User Id");

            return new DiscountCalculator(employee.EmployeeType).Calculate(amount, employee.YearsServed);
        }

        public static decimal SimulateEmployeeDiscount(decimal amount, int employeeTypeId, int yearsServed)
        {
            var employee = new Employee()
            {
                EmployeeTypeId = employeeTypeId,
                StartDate = DateTime.Now.AddYears(-1 * yearsServed)
            };

            return new DiscountCalculator(employee.EmployeeType).Calculate(amount, employee.YearsServed);
        }
    }
}
