using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bibliotheque.Models;

namespace bibliotheque.Controllers;

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

    public IActionResult Borrow()
    {
        return View();
    }

    public IActionResult BookEntry()
    {
        return View();
    }

    public IActionResult NewBookEntry()
    {
        return View();
    }

    public IActionResult OldBookEntry()
    {
        return View();
    }

    public IActionResult ClientHistory()
    {
        return View();
    }

    public IActionResult ClientInformation()
    {
        return View();
    }

    public IActionResult Return()
    {
        return View();
    }

    public IActionResult Buy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

