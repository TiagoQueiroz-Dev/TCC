using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "obrigatorio")]
        [EmailAddress(ErrorMessage = "email invalido")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "obrigatorio")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }
        [Display(Name = "Lembrar de mim")]
        public bool verificar { get; set; }
    }
}