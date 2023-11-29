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

        public decimal ValorTotalPedido { get; set; }


        public EstoquePedidoNotaModel(List<EstoqueModel> estoque)
        {
            this.Estoque = estoque;
        }
        
        public EstoquePedidoNotaModel()
        {
            
        }

        public void SomarTotal(){
            decimal somaParcial = 0;
            for(int i=0;i<Pedidos.Count;i++){
                for(int j=0;j<Estoque.Count;j++){
                    if(Pedidos[i].IdProduto == Estoque[j].Id){
                        somaParcial += Estoque[j].ValorUnid*Pedidos[i].Quantidade;
                    }
                }
            }
            this.ValorTotalPedido = somaParcial;
        }

        
    }
}