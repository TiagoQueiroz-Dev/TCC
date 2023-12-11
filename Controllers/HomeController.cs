using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;
using TCC.Repository.Nota;

namespace TCC.Controllers;

[Authorize]
public class HomeController : Controller
{
    public readonly IEstoqueRepository _estoqueRepository;
    public readonly INotaRepository _notaRepository;
    public HomeController(IEstoqueRepository estoqueRepository,INotaRepository notaRepository)
    {
        _estoqueRepository = estoqueRepository;
        _notaRepository = notaRepository;
    }
    public IActionResult Index()
    {
        RelatorioModel geral = new RelatorioModel();
        geral.Estoque = _estoqueRepository.PoucoEstoque();
        geral.Notas = _notaRepository.NotasRecolher();
        return View(geral);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
