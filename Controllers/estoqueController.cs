using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;

namespace TCC.Controllers;

public class estoqueController : Controller
{
    public readonly IEstoqueRepository _estoqueRepository;

    public estoqueController(IEstoqueRepository estoqueRepository){
        _estoqueRepository = estoqueRepository;
    }

    public IActionResult Index()
    {
        return View(_estoqueRepository.ListarEstoque());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
