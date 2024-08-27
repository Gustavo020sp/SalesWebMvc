using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();

            departments.Add(new Department { Id = 1, Name = "Clothes" });
            departments.Add(new Department { Id = 2, Name = "Foods" });
            departments.Add(new Department { Id = 3, Name = "Vehicles" });

            return View(departments);
        }
    }
}
