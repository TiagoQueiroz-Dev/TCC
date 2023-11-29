using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class NotaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public int Telefone { get; set; }
        public int DataEmissao { get; set; }
        public int DataRecolhimento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int Cep { get; set; }
        public int Numero { get; set; }
    }
}