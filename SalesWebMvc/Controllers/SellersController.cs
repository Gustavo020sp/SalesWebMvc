using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerservice;
        private readonly DepartmentService _departmentservice;

        public SellersController(SellerService sellerservice, DepartmentService departmentservice)
        {
            _sellerservice = sellerservice;
            _departmentservice = departmentservice;
        }

        public IActionResult Index()
        {          
            return View(_sellerservice.FindAll());
        }


        // GET: Sellers/Create
        public IActionResult Create()
        {
            var departments = _departmentservice.FindAll();
            var viewmodel = new SellerFormViewModel { Departments = departments};
            return View(viewmodel);
        }

        //POST: Sellers/Create
        [HttpPost]
        public IActionResult Create(Seller seller)
        {
            _sellerservice.Insert(seller);
            return RedirectToAction("Index");
        }
    }
}
