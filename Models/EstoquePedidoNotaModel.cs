using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class EstoquePedidoNotaModel
    {
        public List<EstoqueModel> Estoque {get; set;}

        public List<PedidoModel> Pedidos { get; set; }

        public NotaModel NovaNota {get; set;}


        public EstoquePedidoNotaModel(List<EstoqueModel> estoque)
        {
            this.Estoque = estoque;
        }
        
        public EstoquePedidoNotaModel()
        {
            
        }


        
    }
}