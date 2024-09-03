using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SalesWebMvc.Data;

namespace SalesWebMvc.Controllers
{
    public class UserController : Controller
    {
        //Classe personalizada do DbContext do Entity Framework
        private readonly SalesWebMvcContext _context;


        //Construtor
        public UserController(SalesWebMvcContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.HideNavbar = true;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);
            if (user != null)
            {
                ViewBag.HideNavbar = false;
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserName", user.UserName);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Wrong Username or Password");
                return View();
            }
        }

        public IActionResult Logout() 
        { 
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
