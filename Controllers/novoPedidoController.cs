using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;

namespace TCC.Controllers;

public class novoPedidoController : Controller
{
    Contexto _db;
    public novoPedidoController(Contexto db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var banco = _db.EstoqueGeral.ToList();

        return View(banco);
    }
    [HttpPost]
    public IActionResult Cadasto(Pedido pedido)
    {
         _db.Pedidos.Add(pedido);
         _db.SaveChanges();



        return RedirectToAction("NovaNota");
    }
    public IActionResult NovaNota()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
