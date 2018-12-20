using System;

namespace everis.SimpleProject.Domain.Models
{
    public class Usuario : Entity
    {


        public string NomeUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool SenhaTemporaria { get; set; }

        public DateTime DataCadastro { get; set; }

        public override void MergeFrom(object other)
        {
            return;
        }
    }
}