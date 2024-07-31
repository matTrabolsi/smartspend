using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using spendsmart.Models;

namespace spendsmart.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly SpendSmartDbContext _context;

    public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Expenses()
    {
        return View();
    }

    public IActionResult CreateEditExpenses()
    {
        return View();
    }

    public IActionResult CEEForm(Expense model)
    {

        _context.Expenses.Add(model);
        _context.SaveChanges();

        return RedirectToAction("CreateEditExpenses");
    }
}
