using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using TCC.Models;

namespace TCC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UsuarioModel Login){
            
            
                var result = await _signInManager.PasswordSignInAsync(Login.Email, Login.Senha, Login.verificar, false);
                if(result.Succeeded){
                return RedirectToAction("Index","Home");
                }else{
                    return RedirectToAction("Index");
                }    
            
        }
        public IActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registrar(CadastrUsuarioModel novoUsuario)
        {
           
                var user = new IdentityUser{
                    UserName = novoUsuario.Email,
                    Email = novoUsuario.Email
                };

                var result = await _userManager.CreateAsync(user, novoUsuario.Senha);
                if(result.Succeeded){
                    return RedirectToAction("Index");
                }else{
                    return RedirectToAction("Registro");
                }
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}