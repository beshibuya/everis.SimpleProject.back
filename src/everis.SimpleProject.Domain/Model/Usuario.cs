using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Model
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }

        public string NomeUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool SenhaTemporaria { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataDesativacao { get; set; }
    }
}