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

        public async Task<IActionResult> Index()
        {
            return View(await _sellerservice.FindAllAsync());
        }


        // GET: Sellers/Create
        public async Task<IActionResult> Create()
        {
            var departments = await _departmentservice.FindAllAsync();
            var viewmodel = new SellerFormViewModel { Departments = departments };
            return View(viewmodel);
        }

        //POST: Sellers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                return View(seller);
            }
            else
            {
                await _sellerservice.InsertAsync(seller);
                return RedirectToAction("Index");
            }
        }

        // GET: Sellers/Delete
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _sellerservice.FindByIdAsync(id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        //POST: Sellers/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Seller seller)
        {
            await _sellerservice.RemoveAsync(seller);
            return RedirectToAction("Index");
        }

        // GET: Sellers/Details
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _sellerservice.FindByIdAsync(id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // GET: Sellers/Edit
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _sellerservice.FindByIdAsync(id);
            if (seller == null)
            {
                return NotFound();
            }

            List<Department> departments =  await _departmentservice.FindAllAsync();
            SellerFormViewModel viewmodel = new SellerFormViewModel { Seller = seller, Departments = departments };

            return View(viewmodel);
        }

        //POST: Sellers/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                return View(seller);
            }
            else
            {
                await _sellerservice.UpdateAsync(seller);
                return RedirectToAction("Index");
            }
        }
    }
}
