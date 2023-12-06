using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCC.Models
{
    public class NotaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF_CNPJ { get; set; }
        public int Telefone { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime DataEmissao { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime DataRecolhimento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public int Cep { get; set; }
        public int Numero { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotal { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorPag { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorDesconto { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? TaxaEntrega { get; set; }
        public bool StatusNota { get; set; }
    }
}