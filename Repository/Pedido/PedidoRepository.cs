using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public PedidoModel AdicionarPedido(PedidoModel novoPedido)
        {
            _bancoContext.Pedidos.Add(novoPedido);
            
            _bancoContext.SaveChanges();
            return novoPedido;
           
        }
    }
}