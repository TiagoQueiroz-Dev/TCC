using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class ArmazenarPedidos
    {
        public static ListaPedidos Armazenar;

        public ArmazenarPedidos()
        {
            Armazenar = new ListaPedidos();
        }
    }
}