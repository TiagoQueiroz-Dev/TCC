using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Repository
{
    public interface IEstoqueRepository 
    {
        List<EstoqueModel> ListarEstoque();
    }
}