using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;

namespace TCC.Controllers;

public class estoqueController : Controller
{
    public readonly IEstoqueRepository _estoqueRepository;

    public estoqueController(IEstoqueRepository estoqueRepository)
    {
        _estoqueRepository = estoqueRepository;
    }

    public IActionResult Index()
    {
        ViewBag.Page = "Estoque";
        var estoque = _estoqueRepository.ListarEstoque();
        return View(estoque);
    }

    public IActionResult EditarProduto(int id)
    {
        ViewBag.Page = "Estoque";
        var estoque = _estoqueRepository.ListarEstoque();

        EstoqueModel produto = new EstoqueModel();

        foreach (var item in estoque)
        {
            if (item.Id == id)
            {
                produto = item;
                break;
            }
        }
        return View(produto);
    }

    [HttpPost]
    public IActionResult ValidarEdit(EstoqueModel produtoNovo)
    {
         _estoqueRepository.EditarEstoque(produtoNovo);
        return RedirectToAction("Index");

    }
    public IActionResult AddProduto(){
        ViewBag.Page = "Estoque";
        EstoqueModel novoProduto = new EstoqueModel();
        return View(novoProduto);
    }
    [HttpPost]
    public IActionResult ValidarNovoProd(EstoqueModel novoProduto){
        novoProduto.Disponiveis = novoProduto.QuantidadeTotal;
        _estoqueRepository.AdicionarEstoque(novoProduto);
        return RedirectToAction("Index");
    }
    public IActionResult ExcluirProduto(int id){
            _estoqueRepository.ExcluirProduto(id);
        return RedirectToAction("Index");
    }

}
