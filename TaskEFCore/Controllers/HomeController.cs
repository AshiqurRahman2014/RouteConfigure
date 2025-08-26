using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TaskEFCore.Models;

namespace TaskEFCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }

        public IActionResult Accountant()
        {
            return View();
        }

        public IActionResult Chemist()
        {
            return View();
        }

        public IActionResult AddDoctor()
        {
            return View();
        }
        public IActionResult EditDoctor()
        {
            return View();
        }
        public IActionResult DeleteDoctor()
        {
            return View();
        }
        public IActionResult DetailsDoctor()
        {
            return View();
        }

        public IActionResult AddAccountant()
        {
            return View();
        }

        public IActionResult EditAccountant()
        {
            return View();
        }
        public IActionResult DeleteAccountant()
        {
            return View();
        }
        public IActionResult DetalisAccountant()
        {
            return View();
        }

        public IActionResult AddChemist()
        {
            return View();
        }

        public IActionResult EditChemist()
        {
            return View();
        }
        public IActionResult DeleteChemist()
        {
            return View();
        }
        public IActionResult DetailsChemist()
        {
            return View();
        }

        public IActionResult AddCertificates()
        {
            return View();
        }


        public IActionResult Privacy()
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
