using Microsoft.AspNetCore.Mvc;

namespace Archive2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult addUser()
        {
            return View();
        }
        public IActionResult editUser()
        {
            return View();
        }
       public IActionResult SendMessage()
        {
            return View();
        }
        public IActionResult ViewMessage()
        { 
        return View();
        }
        public IActionResult editProfile()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}
