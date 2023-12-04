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
        var estoque = _estoqueRepository.ListarEstoque();
        return View(estoque);
    }

    public IActionResult EditarProduto(int id)
    {
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
        var prodVelho = _estoqueRepository.BuscarProduto(produtoNovo.Id);
        if (prodVelho != null)
        {
            if (prodVelho.Nome != produtoNovo.Nome)
            {
                prodVelho.Nome = produtoNovo.Nome;
            }
            if (prodVelho.QuantidadeTotal != produtoNovo.QuantidadeTotal)
            {
                prodVelho.QuantidadeTotal = produtoNovo.QuantidadeTotal;
            }
            if (prodVelho.ValorUnid != produtoNovo.ValorUnid)
            {
                prodVelho.ValorUnid = produtoNovo.ValorUnid;
            }
            _estoqueRepository.EditarEstoque(produtoNovo);
        }
        return RedirectToAction("Index");

    }

}
