using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace firstAppOfMVC.Models
{
    public class UsuarioModel
    {
        
        [StringLength(50, ErrorMessage = "O campo Nome permite no maximo 50 caracteres")]
        private string nome;
        [Required]
        private string sobrenome;
        private string endereco;
        [StringLength(50)]
        [Required(ErrorMessage ="Informe o Email")]
        [RegularExpression(@"\w+([-+.']*@\w+([-.]\w+)*\.\w+([-.]\w+)*",ErrorMessage ="Email Inválido")]
        private string email;
        [DataType(DataType.Date)]
        private DateTime nascimento;

        [DisplayName("Primeiro Nome")]
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Nascimento
        {
            get
            {
                return nascimento;
            }

            set
            {
                nascimento = value;
            }
        }
    }
}
