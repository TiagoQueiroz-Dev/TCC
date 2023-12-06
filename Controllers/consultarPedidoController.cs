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
        List<NotaModel> AllNotas = new List<NotaModel>(); 
        AllNotas = _notaRepository.TodasNotas();
        
        return Ok(AllNotas);
    }

    [HttpPost]
    public IActionResult ConsultaNota(string busca,string opc)
    {
        Console.WriteLine(busca,opc);
        EstoquePedidoNotaModel estoquePedidoNota = new EstoquePedidoNotaModel();
        ListaConsultaNotasModel consulta = new ListaConsultaNotasModel();
        
        estoquePedidoNota.ListaNotas = consulta;
        
        estoquePedidoNota.ListaNotas.stringBusca = busca;
        estoquePedidoNota.ListaNotas.opcBusca = opc;
        
        if (estoquePedidoNota.ListaNotas.stringBusca != null && estoquePedidoNota.ListaNotas.opcBusca != null)
        {
            estoquePedidoNota.ListaNotas.NotasEncontradas = _notaRepository.BuscarNotas(estoquePedidoNota.ListaNotas.stringBusca, estoquePedidoNota.ListaNotas.opcBusca);
            //Console.WriteLine(estoquePedidoNota.ListaNotas.NotasEncontradas);

            return Ok(estoquePedidoNota);
        }
        //necessário notificar usuário sobre o erro de busca
        return Ok("pix");
    }

    public IActionResult ResultPesquisa(EstoquePedidoNotaModel estoquePedidoNota)
    {
        return Ok(estoquePedidoNota);
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
