using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout() 
        {
            // Sign out the user
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Clear session
            HttpContext.Session.Clear();

            // Redirect to the home page or login page
            ViewBag.HideNavbar = true;
            return RedirectToAction("Index", "User");
        }

    }
}
