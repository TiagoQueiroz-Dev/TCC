using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Database;
using TCC.Models;

namespace TCC.Repository.Nota
{
    public class NotaRepository : INotaRepository
    {
        public readonly BancoContext _bancoContex;

        public NotaRepository(BancoContext bancoContext)
        {
            _bancoContex = bancoContext;
        }

        public NotaModel AdicionarNota(NotaModel novaNota)
        {
            _bancoContex.Notas.Add(novaNota);
            _bancoContex.SaveChanges();
            return novaNota;
        }
    }
}