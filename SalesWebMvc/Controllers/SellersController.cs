using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest;
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
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerservice.Insert(seller);
            return RedirectToAction("Index");
        }

        // GET: Sellers/Delete
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = _sellerservice.FindById(id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        //POST: Sellers/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Seller seller)
        {
            _sellerservice.Remove(seller);
            return RedirectToAction("Index");
        }

        // GET: Sellers/Details
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = _sellerservice.FindById(id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // GET: Sellers/Edit
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = _sellerservice.FindById(id);
            if (seller == null)
            {
                return NotFound();
            }

            List<Department> departments = _departmentservice.FindAll();
            SellerFormViewModel viewmodel = new SellerFormViewModel { Seller = seller, Departments = departments};

            return View(viewmodel);
        }

        //POST: Sellers/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Seller seller)
        {
            _sellerservice.Update(seller);
            return RedirectToAction("Index");
        }
    }
}
