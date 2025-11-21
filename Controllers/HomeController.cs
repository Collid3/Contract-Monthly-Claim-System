using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;
using Microsoft.VisualBasic;

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
        var allClaims = _context.Claims.ToList();
        return View(allClaims);
    }

    public IActionResult AddClaim()
    {
        return View();
    }

    public IActionResult VerifyClaims()
    {
        var allClaims = _context.Claims.ToList();
        return View(allClaims);
    }

    public IActionResult SubmitClaim(Claim claim)
    {
        var allClaims = _context.Claims.ToList();
        int id;

        if (allClaims.Count > 0)
        {
            id = allClaims[allClaims.Count - 1].Id + 1;
        } else
        {
            id = 0;
        }

        claim.Id = id;
        claim.Status = "Pending";
        claim.SubmissionDate = DateTime.Today;
        _context.Add(claim);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult ApproveClaim(int? id)
    {

        if (id != null)
        {
            var editedclaim = _context.Claims.SingleOrDefault(claim => claim.Id == id);

            if (editedclaim != null)
            {
                editedclaim.Status = "Approved";   
                _context.SaveChanges();
            }
        }

        return RedirectToAction("VerifyClaims");
    }

    public IActionResult RejectClaim(int? id)
    {
        if (id != null)
        {
            var editedclaim = _context.Claims.SingleOrDefault(claim => claim.Id == id);

            if (editedclaim != null)
            {
                editedclaim.Status = "Rejected";             
                _context.SaveChanges();
            }

        }

        return RedirectToAction("VerifyClaims");
    }

        public IActionResult Profile()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
