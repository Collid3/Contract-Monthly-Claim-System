using System.Diagnostics;
using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult HandleLogin()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult HandleRegister()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult AddClaim()
        {
            return View();
        }

        public IActionResult VerifyClaims()
        {
            return View();
        }

        public IActionResult SubmitClaim()
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
