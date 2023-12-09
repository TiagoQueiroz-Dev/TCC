using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class NotaModel
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Nome { get; set; }
        [Column(TypeName="BIGINT")]
        public int CPF_CNPJ { get; set; }
        [Column(TypeName="BIGINT")]
        public int Telefone { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime DataEmissao { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime DataRecolhimento { get; set; }
        [MaxLength(50)]
        public string Cidade { get; set; }
        [MaxLength(50)]
        public string Bairro { get; set; }
        [MaxLength(50)]
        public string Rua { get; set; }
        [MaxLength(50)]
        public string Complemento { get; set; }
        [Column(TypeName ="MEDIUMINT")]
        public int Cep { get; set; }
        
        public int Numero { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        
        public decimal ValorTotal { get; set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorPago { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorDesconto { get; set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal? TaxaEntrega { get; set; }
        public bool StatusNota { get; set; }
    }
}