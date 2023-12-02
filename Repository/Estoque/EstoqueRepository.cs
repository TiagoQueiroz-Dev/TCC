using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.WebEncoders.Testing;
using TCC.Database;
using TCC.Models;
using TCC.Repository.Pedido;

namespace TCC.Repository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly BancoContext _dataContexto;
        private readonly IPedidoRepository _pedidoRepository;


        public EstoqueRepository (BancoContext dataContexto,IPedidoRepository pedidoRepository){
            _dataContexto = dataContexto;   
            _pedidoRepository = pedidoRepository;
        }

        public EstoqueModel BaixaEstoque(EstoqueModel estoque,PedidoModel pedido)
        {
            var produtoEstoque = _dataContexto.EstoqueGeral.Find(estoque.Id);

            if(produtoEstoque.Id == pedido.IdProduto){
                if(produtoEstoque.Disponiveis >= pedido.Quantidade){
                    estoque.Disponiveis -= pedido.Quantidade;
                    estoque.Alugados += pedido.Quantidade; 
                    _dataContexto.EstoqueGeral.Update(estoque);
                    _pedidoRepository.AdicionarPedido(pedido);
                    _dataContexto.SaveChanges();
                }
            }
            return estoque;
        }

        public List<EstoqueModel> ListarEstoque()
        {
            return _dataContexto.EstoqueGeral.ToList();
             
        }
        
    }
}