using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Repository.Usuario
{
    public interface IUsuarioRepository
    {
        UsuarioModel ValidarLogin(string login,string senha);
    }
}