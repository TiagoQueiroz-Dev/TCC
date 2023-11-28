using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdNota{ get; set;}
        public int Quantidade { get; set; }
    }
}