using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class ItensEstoque
    {
        public string IdProduto { get; set; }
        public string Nome { get; set; }
        public int QuantidadeTotal  { get; set; }
        public int Alugados { get; set; }
        public int Disponiveis { get; set; }
        public double ValorUnid { get; set; }

        public ItensEstoque (string id, string nome, int quantidadeTotal, int alugados,double valor){
            this.IdProduto = id;
            this.Nome = nome;
            this.QuantidadeTotal = quantidadeTotal;
            this.Alugados = alugados;
            this.Disponiveis = quantidadeTotal-alugados;
            this.ValorUnid = valor;
        }
    }
}