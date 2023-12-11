using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Database;
using TCC.Repository.Conta;

namespace TCC.Repository.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly BancoContext _bancoContext;
        public readonly IContaRepository _contaRepository;
        public UsuarioRepository(BancoContext bancoContext, IContaRepository contaRepository)
        {
            _bancoContext = bancoContext;  
            _contaRepository = contaRepository;
        }
        public bool AutenticacaoValida(string email, string senha)
        {   
            var usuarioValidado = _bancoContext.Usuarios.FirstOrDefault(u => u.EmailUsuario == email && u.Senha == senha);
            
            if(usuarioValidado != null){
                return true;
            }else{
                return false;
            }
        }

        public string NomeUser(string email, string senha)
        {
            var usuarioValidado = _bancoContext.Usuarios.FirstOrDefault(u => u.EmailUsuario == email && u.Senha == senha);
            return usuarioValidado.NomeUsuario;
        }

        public string TipoUsuario(string email, string senha)
        {
            var usuarioValidado = _bancoContext.Usuarios.FirstOrDefault(u => u.EmailUsuario == email && u.Senha == senha);
            var tipoConta = _contaRepository.RoleConta(usuarioValidado.IdConta);
            return tipoConta;
        }
    }
}