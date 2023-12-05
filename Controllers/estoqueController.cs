using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;

namespace TCC.Controllers;
[ApiController]
[Route("api/[controller]/[action]")]
public class estoqueController : Controller
{
    public readonly IEstoqueRepository _estoqueRepository;

    public estoqueController(IEstoqueRepository estoqueRepository)
    {
        _estoqueRepository = estoqueRepository;
    }

    [HttpGet]
   public IActionResult Index()
    {
        var estoque = _estoqueRepository.ListarEstoque();
        return Ok(estoque);
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
        return Ok(produto);
    }

    [HttpPost]
    public IActionResult ValidarEdit(EstoqueModel produtoNovo)
    {
         _estoqueRepository.EditarEstoque(produtoNovo);
        return Ok();

    }
    public IActionResult AddProduto(){
        EstoqueModel novoProduto = new EstoqueModel();
        return View(novoProduto);
    }

    [HttpPost]
    public IActionResult ValidarNovoProd(EstoqueModel novoProduto){
        _estoqueRepository.AdicionarEstoque(novoProduto);
        return Ok();
    }
    public IActionResult ExcluirProduto(int id){
            _estoqueRepository.ExcluirProduto(id);
        return Ok();
    }

}
