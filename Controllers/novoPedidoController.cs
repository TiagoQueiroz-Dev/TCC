using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using TCC.Models;

namespace TCC.Controllers;

public class novoPedidoController : Controller
{
    private readonly ILogger<novoPedidoController> _logger;

    public novoPedidoController(ILogger<novoPedidoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //fake banco de dados
        var Produtos = new NovoPedidoModel();
        ViewBag.Produtos = Produtos.ListaItens;

        return View();
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
