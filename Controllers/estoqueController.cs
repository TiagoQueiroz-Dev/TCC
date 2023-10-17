using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;

namespace TCC.Controllers;

public class estoqueController : Controller
{
    Contexto _db;
    public estoqueController(Contexto db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var banco = _db.EstoqueGeral.ToList();
        return View(banco);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
