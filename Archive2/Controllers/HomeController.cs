using Archive2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using modelfor_archive.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Archive2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private Archive2Context Context = new Archive2Context();
     

        public IActionResult UserHome()
        {
            return View();
        }
       
        public IActionResult AdminHome()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login , bool loginAsAdmin)
        {
            string email = login.Email;
            string password = login.Password;

            UserAcc User = Context.UserAccs.Where(s => s.AcadMail == email && s.Pass == password).FirstOrDefault();

            if (User == null || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.ErrorMessage = "Please enter a valid email and password.";
                return View();
            }

            if (loginAsAdmin && !User.IsAdmin)
            {
                ViewBag.ErrorMessage = "You are not authorized to login as an admin.";
                return View();
            }
            else if (loginAsAdmin && User.IsAdmin)
            {
                return RedirectToAction("AdminHome", "Home");
            }
            else if (!loginAsAdmin && User.IsAdmin)
            {
                return RedirectToAction("AdminHome", "Home");

            }
            else
            {
                return RedirectToAction("UserHome", "Home");
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public IActionResult ShowAll()
        {
            List<UserAcc> allUsers = Context.UserAccs.AsNoTracking().ToList();
            ViewBag.AllUsers = allUsers;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
