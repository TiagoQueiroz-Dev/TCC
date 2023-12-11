using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class CadastrUsuarioModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirma senha")]
        [Compare("Senha", ErrorMessage = "Senhas divergentes")]
        public string? ConfirmSenha { get; set; }
    }
}