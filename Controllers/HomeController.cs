using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;

namespace ContractMonthlyClaimSystem.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ClaimDbContext _context;

    public HomeController(ILogger<HomeController> logger, ClaimDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
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

        public IActionResult SubmitClaim(Claim claim)
        {
            // _context.Add(claim);
            // _context.SaveChanges();

            return RedirectToAction("Index");
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
