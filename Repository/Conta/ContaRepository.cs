using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Database;

namespace TCC.Repository.Conta
{
    public class ContaRepository : IContaRepository
    {
        public readonly BancoContext _bancoContext;
        public ContaRepository( BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public string RoleConta(int id)
        {
            var conta = _bancoContext.Contas.Find(id);
            
            return conta.TipoConta;


        }
    }
}