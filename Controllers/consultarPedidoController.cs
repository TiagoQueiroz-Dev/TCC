using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;
using TCC.Repository.Nota;
using TCC.Repository.Pedido;

namespace TCC.Controllers;

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

    public IActionResult Index()
    {
        EstoquePedidoNotaModel estoquePedidoNota = new EstoquePedidoNotaModel();
        return View(estoquePedidoNota);
    }

    [HttpPost]
    public IActionResult ConsultaNota(EstoquePedidoNotaModel estoquePedidoNota)
    {

        if (estoquePedidoNota.ListaNotas.stringBusca != null && estoquePedidoNota.ListaNotas.opcBusca != null)
        {
            estoquePedidoNota.ListaNotas.NotasEncontradas = _notaRepository.BuscarNotas(estoquePedidoNota.ListaNotas.stringBusca, estoquePedidoNota.ListaNotas.opcBusca);
            //Console.WriteLine(estoquePedidoNota.ListaNotas.NotasEncontradas);

            return View("ResultPesquisa", estoquePedidoNota);
        }
        //necessário notificar usuário sobre o erro de busca
        return View("Index");
    }

    public IActionResult ResultPesquisa(EstoquePedidoNotaModel estoquePedidoNota)
    {
        return View(estoquePedidoNota);
    }

    public IActionResult VisualizarNota(int id){
        EstoquePedidoNotaModel pedidoNota = new EstoquePedidoNotaModel();
        pedidoNota.NovaNota = _notaRepository.BuscarNota(id);
        pedidoNota.Pedidos = _pedidoRepository.PedidosNota(id);
        pedidoNota.Estoque = _estoqueRepository.ListarEstoque();
        return View(pedidoNota);
    }

    [HttpPost]
    public IActionResult BaixarNota(EstoquePedidoNotaModel nota){
        _notaRepository.BaixarNota(nota.NovaNota);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
