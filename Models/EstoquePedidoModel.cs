using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class EstoquePedidoModel
    {
        public List<EstoqueModel> Estoque {get; set;}

        public List<PedidoModel> Pedidos { get; set; }


        public EstoquePedidoModel(List<EstoqueModel> estoque)
        {
            this.Estoque = estoque;
        }
        
        public EstoquePedidoModel()
        {
            
        }


        
    }
}