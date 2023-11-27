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
            PedidoModel b = new PedidoModel();
            List<PedidoModel> a = ArmazenarPedidos.Armazenar.Listar();
            _bancoContext.Pedidos.AddRange(a);
            _bancoContext.SaveChanges();
            return b;
           
        }
    }
}