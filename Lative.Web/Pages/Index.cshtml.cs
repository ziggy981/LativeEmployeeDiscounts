using Lative.Domain.Entities;
using Lative.Services;
using Lative.Services.Calculators;
using Lative.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Lative.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        private readonly string _connectionString;

        [BindProperty]
        public DiscountCalculatorModel DiscCalcModel { get; set; }

        [BindProperty]
        public decimal? DiscountResult { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async void OnGet()
        {
        }

        public void OnPost(DiscountCalculatorModel discCalcModel)
        {
            DiscountResult = EmployeeDiscountService.SimulateEmployeeDiscount(discCalcModel.Amount, discCalcModel.EmployeeTypeId, discCalcModel.YearsServed);
        }
    }
}
