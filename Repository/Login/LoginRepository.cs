using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using TCC.Database;
using TCC.Models;

namespace TCC.Repository.Login
{
    public class LoginRepository : ILoginRepository
    {
        private readonly UserManager<IdentityUser> _UserManager;

        public LoginRepository(UserManager<IdentityUser> userManager)
        {
            _UserManager = userManager;
        }

        public string validarLogin(IdentityUser login)
        {
            var usuario = new LoginModel();
            if(_UserManager.FindByIdAsync(login.Id) != null){
                
                if (usuario.Nome == login.UserName && usuario.Senha == login.PasswordHash)
                {
                    return "True";
                }
            }
            return "False";
        }
    }
}