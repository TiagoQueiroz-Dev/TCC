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

        public EstoqueModel BuscarProduto(int idProduto)
        {
            var produto = _dataContexto.EstoqueGeral.Find(idProduto);

            return produto;
        public EstoqueModel BaixaEstoque(PedidoModel pedido)
        {
            var produtoEstoque = _dataContexto.EstoqueGeral.Find(pedido.IdProduto);

            if(produtoEstoque != null){
                if(produtoEstoque.Disponiveis >= pedido.Quantidade){
                    produtoEstoque.Disponiveis -= pedido.Quantidade;
                    produtoEstoque.Alugados += pedido.Quantidade; 
                    _dataContexto.EstoqueGeral.Update(produtoEstoque);
                    _pedidoRepository.AdicionarPedido(pedido);
                    _dataContexto.SaveChanges();
                }
            }
            return produtoEstoque;
        }

        public List<EstoqueModel> ListarEstoque()
        {
            return _dataContexto.EstoqueGeral.ToList();
             
        }
        
    }
}