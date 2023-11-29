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
        EstoquePedidoNotaModel estoquePedidoNota = new EstoquePedidoNotaModel(_estoqueRepository.ListarEstoque());
        //Incluindo a lista que temos no Estoque
        return View(estoquePedidoNota);
    }

    [HttpPost]
    public IActionResult NovoPedido(EstoquePedidoNotaModel estoquePedidoNota){

        estoquePedidoNota.Estoque = _estoqueRepository.ListarEstoque();

        estoquePedidoNota.Pedidos.RemoveAll(Pedidos => Pedidos.Quantidade == 0);
        
        estoquePedidoNota.SomarTotal();

        return View("NovaNota",estoquePedidoNota);
        //representa ação do form da View "Index" para fezer um pedido
    }

    public IActionResult NovaNota(EstoquePedidoNotaModel estoquePedidoNota){
        
        return View();
    }

    [HttpPost]
    public IActionResult CadastrarNota(EstoquePedidoNotaModel estoquePedidoNota){

        if(estoquePedidoNota.Pedidos != null){
            Random random = new Random();
            var numNota = random.Next(1,101);

            foreach(var item in estoquePedidoNota.Pedidos){

                item.IdNota = numNota;
                _pedidoRepository.AdicionarPedido(item);
        
            }

            _notaRepository.AdicionarNota(estoquePedidoNota.NovaNota);
        return RedirectToAction("Index","Home");
        }else
        {
            return RedirectToAction("Index");
          //Necessário que seja informado um erro caso ele entre  
        }
        
        //representa ação do form da View "NovaNota" para gerar uma nota
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
