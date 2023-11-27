using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class ListaPedidos
    {
        public static List<PedidoModel> Pedidos;

        public ListaPedidos()
        {
            Pedidos = new List<PedidoModel>();
        }
        public void Inserir (List<PedidoModel> pedido){
            Pedidos.AddRange(pedido);
        }

        public List<PedidoModel> Listar(){
            return Pedidos;
        }
    }
}