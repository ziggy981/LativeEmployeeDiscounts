using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lative.Web.Models
{
    public class DiscountCalculatorModel
    {
        [Required]
        public int EmployeeTypeId { get; set; }

        [Required]
        [Range(0, Int64.MaxValue, ErrorMessage = "Amount should contain only numbers")]
        public decimal Amount { get; set; }

        [Required]
        [Range(0, Int64.MaxValue, ErrorMessage = "Years Served should contain only numbers")]
        public int YearsServed { get; set; }
    }
}
