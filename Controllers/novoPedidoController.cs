using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;
using TCC.Repository.Nota;
using TCC.Repository.Pedido;

namespace TCC.Controllers;

public class novoPedidoController : Controller
{
    public readonly IPedidoRepository _pedidoRepository;
    public readonly INotaRepository _notaRepository;
    public readonly IEstoqueRepository _estoqueRepository;

    public novoPedidoController(IPedidoRepository pedidoRepository, INotaRepository notaRepository, IEstoqueRepository estoqueRepository)
    {
        _pedidoRepository = pedidoRepository;
        _notaRepository = notaRepository;
        _estoqueRepository = estoqueRepository;
    }

    
    public IActionResult Index()
    {
        return View(_estoqueRepository.ListarEstoque());
    }

    [HttpPost]
    public IActionResult NovoPedido(PedidoModel novoPedido){

        _pedidoRepository.AdicionarPedido(novoPedido);
        return RedirectToAction("NovaNota");
        //representa ação do form da View "Index" para fezer um pedido
    }

    public IActionResult NovaNota(){
        return View();
    }

    [HttpPost]
    public IActionResult CadastrarNota(NotaModel novaNota){
        _notaRepository.AdicionarNota(novaNota);
        return RedirectToAction("Index","Home");
        //representa ação do form da View "NovaNota" para gerar uma nota
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
