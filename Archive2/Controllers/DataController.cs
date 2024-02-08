using Microsoft.AspNetCore.Mvc;

namespace Archive2.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Import()
        {
            return View();
        }
        public IActionResult Export()
        {
            return View();
        }
    }
}
