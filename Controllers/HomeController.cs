using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Database;
using TCC.Models;
using TCC.Repository;
using TCC.Repository.Nota;
using TCC.Repository.Usuario;

namespace TCC.Controllers;

[Authorize]
public class HomeController : Controller
{
    public readonly IEstoqueRepository _estoqueRepository;
    public readonly IUsuarioRepository _usuarioRepository;
    public readonly INotaRepository _notaRepository;
    public HomeController(IEstoqueRepository estoqueRepository,INotaRepository notaRepository,IUsuarioRepository usuarioRepository)
    {
        _estoqueRepository = estoqueRepository;
        _notaRepository = notaRepository;
        _usuarioRepository = usuarioRepository;

    }
    public IActionResult Index()
    {   
        var role = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Role);
        string tipoConta = role?.Value;
        
        ViewBag.Page = "Home";
        RelatorioModel geral = new RelatorioModel();
        geral.Estoque = _estoqueRepository.PoucoEstoque();
        geral.Notas = _notaRepository.NotasRecolher();
        return View(geral);
    }
    
    [Authorize(Roles = "Administrador")]
    public IActionResult CadastrarUsuario(){
        ViewBag.Page = "Cadastro";
        return View();
    }

    
    [HttpPost]
    public IActionResult Cadastrar(string nome,string email,string confirmarEmail, string senha,string confirmarSenha,string tipoConta)
    {   


        ViewBag.Page = "Cadastro";

        if(email == confirmarEmail && senha == confirmarSenha){
            _usuarioRepository.NovoUsuario(nome,email,senha,tipoConta);
        }

        return View("CadastrarUsuario");
    }

    public IActionResult Usuario()
    {   
        ViewBag.Page = "Usuario";
        return View("Usuario");
    }
    public IActionResult Alterar()
    {   
        ViewBag.Page = "Usuario";
        return View("AlterarDados");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
