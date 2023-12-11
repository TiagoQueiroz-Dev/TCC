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
        return View(estoquePedidoNota);
    }

    [HttpPost]
<<<<<<< HEAD
    public IActionResult NovoPedido(EstoquePedidoNotaModel estoquePedidoNota)
    {
            var qtdPedidos = 0;

            estoquePedidoNota.Estoque = _estoqueRepository.ListarEstoque();

            estoquePedidoNota.NovaNota = new NotaModel();

            estoquePedidoNota.Pedidos.RemoveAll(Pedidos => Pedidos.Quantidade == 0);
            
            if(estoquePedidoNota.Pedidos.Count != 0){
            estoquePedidoNota.SomarTotal();

            estoquePedidoNota.NovaNota.ValorPago = 0;

            foreach (var item1 in estoquePedidoNota.Pedidos)
            {
                // aplicada regra de negocio para verificar pagamento imediato das escoras
                foreach (var item2 in estoquePedidoNota.Estoque)

                    if (item1.IdProduto == item2.Id)
                    {
                        if (item2.Nome.Split(' ')[0] == "Escora")
                        {
                            estoquePedidoNota.NovaNota.ValorPago += item2.ValorUnid * item1.Quantidade;
                        }

                    }
                qtdPedidos += item1.Quantidade;
            }

            if (qtdPedidos < 20 || estoquePedidoNota.SubTotalPedido < 500)
            {
                estoquePedidoNota.Entrega = true;
            }
            else
            {
                estoquePedidoNota.Entrega = false;
            }
            return View("NovaNota", estoquePedidoNota);
        }else{
            return RedirectToAction("Index");
        }

       
        //representa ação do form da View "Index" para fezer um pedido
=======
    public IActionResult NovoPedido(){
        _pedidoRepository.AdicionarPedido();
        return RedirectToAction("NovaNota");
;        //representa ação do form da View "Index" para fezer um pedido
>>>>>>> 6ee36a447f7e92a3163e024a93631c844f3ad304
    }

    public IActionResult NovaNota()
    {

        return View();
    }

    [HttpPost]
    public IActionResult CadastrarNota(EstoquePedidoNotaModel estoquePedidoNota)
    {

        if (estoquePedidoNota.Pedidos != null)
        {
            estoquePedidoNota.NovaNota.ValorDesconto = estoquePedidoNota.NovaNota.ValorDesconto / 100 * estoquePedidoNota.NovaNota.ValorTotal;
            Console.WriteLine(estoquePedidoNota.NovaNota.ValorDesconto);

            _notaRepository.AdicionarNota(estoquePedidoNota.NovaNota);

            foreach (var item in estoquePedidoNota.Pedidos)
            {
                //para pegar o id da nota gerada e incuir no pedido, foi criado este metodo de consulta de Id
                item.IdNota = _notaRepository.BuscarIdNota(estoquePedidoNota.NovaNota);

                _estoqueRepository.BaixaEstoque(item);
                //cada item do pedido irá receber o mesmo idNota antes de ser adicionado ao banco
                //_pedidoRepository.AdicionarPedido(item);

            }
            return RedirectToAction("Index", "Home");
        }
        else
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
