using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;
using TCC.Repository.Nota;
using TCC.Repository.Pedido;

namespace TCC.Controllers;
[ApiController]
[Route("api/[controller]/[action]")]
public class consultarPedidoController : Controller
{
    public readonly IPedidoRepository _pedidoRepository;
    public readonly INotaRepository _notaRepository;
    public readonly IEstoqueRepository _estoqueRepository;

    public consultarPedidoController(IPedidoRepository pedidoRepository, INotaRepository notaRepository, IEstoqueRepository estoqueRepository)
    {
        _pedidoRepository = pedidoRepository;
        _notaRepository = notaRepository;
        _estoqueRepository = estoqueRepository;
    }
    [HttpGet]
    public ActionResult Index()
    {
        EstoquePedidoNotaModel estoquePedidoNota = new EstoquePedidoNotaModel();
        return Ok(estoquePedidoNota);
    }

    [HttpPost]
    public IActionResult ConsultaNota(EstoquePedidoNotaModel estoquePedidoNota)
    {

        if (estoquePedidoNota.ListaNotas.stringBusca != null && estoquePedidoNota.ListaNotas.opcBusca != null)
        {
            estoquePedidoNota.ListaNotas.NotasEncontradas = _notaRepository.BuscarNotas(estoquePedidoNota.ListaNotas.stringBusca, estoquePedidoNota.ListaNotas.opcBusca);
            //Console.WriteLine(estoquePedidoNota.ListaNotas.NotasEncontradas);

            return Ok(estoquePedidoNota);
        }
        //necessário notificar usuário sobre o erro de busca
        return Ok();
    }

    public IActionResult ResultPesquisa(EstoquePedidoNotaModel estoquePedidoNota)
    {
        return View(estoquePedidoNota);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
