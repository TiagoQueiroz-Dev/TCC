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
        EstoqueModel BuscarProduto(int idProduto);
        EstoqueModel BaixaEstoque(PedidoModel pedido);

        EstoqueModel EditarEstoque(EstoqueModel produto);
        
        EstoqueModel AdicionarEstoque(EstoqueModel novoProduto);
        EstoqueModel ExcluirProduto(int id);
        List<EstoqueModel> PoucoEstoque();
    }

}