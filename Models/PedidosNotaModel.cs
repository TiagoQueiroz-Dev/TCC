using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class PedidosNotaModel
    {
        public NotaModel NovaNota {get; set;}

        public List<PedidoModel> ListaNovosPedidos {get;set;}
        
        public PedidosNotaModel(List<PedidoModel> novosPedidos)
        {
            ListaNovosPedidos = novosPedidos;
        }
    }
}