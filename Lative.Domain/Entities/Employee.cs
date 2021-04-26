using Lative.Domain.Enums;
using Lative.SharedKernel;
using System;

namespace Lative.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeTypeId { get; set; }
        public DateTime StartDate { get; set; }

        public EmployeeType EmployeeType
        {
            get => (EmployeeType)Enum.Parse(typeof(EmployeeType), EmployeeTypeId.ToString());
        }

        public int YearsServed
        {
            get => DatesCalulator.GetDifferenceInYears(StartDate.Date, DateTime.Today);
        }
    }
}


