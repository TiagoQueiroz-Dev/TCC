using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Database;
using TCC.Models;

namespace TCC.Repository.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly BancoContext _bancoContext;
        public UsuarioRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel ValidarLogin(string login, string senha)
        {   
            UsuarioModel usuario = new UsuarioModel(); 

            return usuario;
        
        }
    }
}