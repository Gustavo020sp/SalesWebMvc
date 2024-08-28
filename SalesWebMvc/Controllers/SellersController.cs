using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerservice;

        public SellersController(SellerService sellerservice)
        {
            _sellerservice = sellerservice;
        }

        public IActionResult Index()
        {          
            return View(_sellerservice.FindAll());
        }


        // GET: Sellers/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: Sellers/Create
        [HttpPost]
        public IActionResult Create(Seller obj)
        {
            _sellerservice.Insert(obj);
            return RedirectToAction("Index");
        }
    }
}
