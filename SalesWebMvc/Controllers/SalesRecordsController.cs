using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        //private readonly SellerService _sellerservice;
        //private readonly DepartmentService _departmentservice;
        private readonly SalesRecordService _salesrecordservice;

        public SalesRecordsController(SalesRecordService salesrecordservice)
        {
            _salesrecordservice = salesrecordservice;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? mindate, DateTime? maxdate)
        {
            if (!mindate.HasValue)
            {
                mindate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxdate.HasValue)
            {
                maxdate = DateTime.Now;
            }
            ViewData["minDate"] = mindate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxdate.Value.ToString("yyyy-MM-dd");
            var sales = await _salesrecordservice.FindByDateAsync(mindate, maxdate);
            return View(sales);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? mindate, DateTime? maxdate)
        {
            if (!mindate.HasValue)
            {
                mindate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxdate.HasValue)
            {
                maxdate = DateTime.Now;
            }
            ViewData["minDate"] = mindate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxdate.Value.ToString("yyyy-MM-dd");
            var sales = await _salesrecordservice.FindByDateGroupingAsync(mindate, maxdate);
            return View(sales);
        }
    }
}
