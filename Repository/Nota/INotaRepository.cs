using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Repository.Nota
{
    public interface INotaRepository
    {
        NotaModel AdicionarNota(NotaModel novaNota);
    }
}