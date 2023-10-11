using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TCC.Models;

public class Estoque
{
    
    public int Id { get; set; }
    [NotNull]
    public string Nome { get; set; }
    [NotNull]
    public int Quantidade { get; set; }
    [NotNull]
    public int Alugados { get; set; }
}