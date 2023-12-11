using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using TCC.Database;
using TCC.Models;

namespace TCC.Repository.Pedido
{
    public class PedidoRepository : IPedidoRepository
    {
        public readonly BancoContext _bancoContext;

        public PedidoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public PedidoModel AdicionarPedido()
        {
            _bancoContext.Pedidos.Add(novoPedido);
            
            _bancoContext.SaveChanges();
            return b;
           
        }

        public List<PedidoModel> PedidosNota(int idNota)
        {   
            List<PedidoModel> listaProdutos = new List<PedidoModel>();

            var produtos = _bancoContext.Pedidos.Where(u => u.IdNota == idNota);
            
            listaProdutos = produtos.ToList();

            return listaProdutos;
        }
    }
}