using CyberSafe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CyberSafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Nav bar: Services, About us, Login , Provacy , CyberLab
        /// All nedded views:
        /// 1. Home Page- The page where our site will load\
        /// * We need info there
        /// * Register and login option
        ///
        /// 2.
        /// </summary>

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult CyberLab()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}