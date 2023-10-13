using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Models;

namespace TCC.Controllers;

public class estoqueController : Controller
{
    private readonly ILogger<estoqueController> _logger;

    public estoqueController(ILogger<estoqueController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
