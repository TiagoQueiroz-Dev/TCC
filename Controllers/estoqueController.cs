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
        //fake banco de dados
        var Produtos = new NovoPedidoModel();
        ViewBag.Produtos = Produtos.ListaItens;
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
