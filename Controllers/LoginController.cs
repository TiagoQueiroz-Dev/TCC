using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCC.Repository.Login;

namespace TCC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly ILoginRepository _ILoginRepository;

        public LoginController(UserManager<IdentityUser> userManager, ILoginRepository iLoginRepository)
        {
            _UserManager = userManager;
            _ILoginRepository = iLoginRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IdentityUser usuario)
        {
            if(_ILoginRepository.validarLogin(usuario) == "True"){
                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}