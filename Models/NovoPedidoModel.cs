using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class NovoPedidoModel
    {
        public List<ItensEstoque> ListaItens { get; set; }

        public NovoPedidoModel(){
            ListaItens = new List<ItensEstoque>
            {
                new ItensEstoque("andaime_1","Andaime 1.0 Metro", 1000, 500,10.99),
                new ItensEstoque("andaime_1.3","Andaime 1.3 Metro", 1000, 500,20.99),
                new ItensEstoque("andaime_1.5","Andaime 1.5 Metro", 1000, 500,30.99),
                new ItensEstoque("andaime_2.0","Andaime 2.0 Metro", 1000, 500,40.99),
                new ItensEstoque("lastro_1","Lastro 1.0 Metro", 1000, 500,50.99),
                new ItensEstoque("lastro_1.5","Lastro 1.5 Metro", 1000, 500,60.99),
                new ItensEstoque("lastro_2","Lastro 2.0 Metro", 1000, 500,70.99),
                new ItensEstoque("escora_3.5","Escora 3.5 Metro", 1000, 500,80.99),
                new ItensEstoque("escora_5","Escora 5.0 Metro", 1000, 500,90.99),
                new ItensEstoque("bitoneira","Bitoneira", 5, 1,100.99),
                new ItensEstoque("pranchao","Pranchão", 10, 5,200.99),
                new ItensEstoque("rodanas","Rodanas", 20, 10,300.99),
                new ItensEstoque("travas","Travas", 10, 5,400.99),
                new ItensEstoque("regulador","P. Regulador", 35, 20,500.99)
            };
        }
    }

}