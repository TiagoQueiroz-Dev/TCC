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
        
        EstoquePedidoModel estoquePedido = new EstoquePedidoModel(_estoqueRepository.ListarEstoque());
        return View(estoquePedido);
    }

    [HttpPost]
    public IActionResult NovoPedido(EstoquePedidoModel novoPedidoProduto){
        
        return RedirectToAction("NovaNota",novoPedidoProduto.Pedidos);
        //representa ação do form da View "Index" para fezer um pedido
    }
    
    public IActionResult NovaNota(List<PedidoModel> listaNovosPedidos){
        PedidosNotaModel pedidoNota = new PedidosNotaModel(listaNovosPedidos);
        return View(pedidoNota);
    }

    [HttpPost]
    public IActionResult CadastrarNota(PedidosNotaModel pedidoNota){

         foreach(var item in pedidoNota.ListaNovosPedidos){

            if (item.Quantidade >0)
            {
                _pedidoRepository.AdicionarPedido(item);
            }
        
        }
        _notaRepository.AdicionarNota(pedidoNota.NovaNota);
        return RedirectToAction("Index","Home");
        //representa ação do form da View "NovaNota" para gerar uma nota
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
