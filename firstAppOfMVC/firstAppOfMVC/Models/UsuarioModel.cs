using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace firstAppOfMVC.Models
{
    public class UsuarioModel
    {
        [DisplayName("Código")]
        [Required]
        public int id { get; set; }
        [StringLength(50, ErrorMessage = "O campo Nome permite no maximo 50 caracteres")]
        [DisplayName("Primeiro Nome")]
        public string nome { get; set; }
        [Required]
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Informe o Email")]
        [EmailAddress]
        public string email { get; set; }
        [DataType(DataType.Date)]
        public DateTime nascimento { get; set; }

     }
}
