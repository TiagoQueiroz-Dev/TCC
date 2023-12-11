using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Repository.Usuario
{
    public interface IUsuarioRepository
    {
        bool AutenticacaoValida (string email,string senha);

        string TipoUsuario(string email, string senha);

        string NomeUser(string email, string senha);
    }
}