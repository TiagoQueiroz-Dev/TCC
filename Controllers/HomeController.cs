using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;

namespace TCC.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;
    Contexto _db;

    public HomeController(Contexto db)
    {
        _db = db;
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
}
