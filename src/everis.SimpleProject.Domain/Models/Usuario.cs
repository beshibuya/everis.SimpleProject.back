using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace everis.SimpleProject.Domain.Models
{
    public class Usuario:Entity
    {
    

        public string NomeUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool SenhaTemporaria { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataDesativacao { get; set; }
    }
}