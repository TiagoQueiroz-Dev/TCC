using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Database;
using TCC.Models;

namespace TCC.Repository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly BancoContext _dataContexto;

        public EstoqueRepository (BancoContext dataContexto){
            _dataContexto = dataContexto;   
        }

        public EstoqueModel BuscarProduto(int idProduto)
        {
            var produto = _dataContexto.EstoqueGeral.Find(idProduto);

            return produto;
        }

        public List<EstoqueModel> ListarEstoque()
        {
            return _dataContexto.EstoqueGeral.ToList();
             
        }
    }
}