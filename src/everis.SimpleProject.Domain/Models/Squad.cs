using System;

namespace everis.SimpleProject.Domain.Models
{
    public class Squad : Entity
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public int IdSquad { get; set; }
        public string GerenteResponsavel { get; set; }
        public string GerenteComunidade { get; set; }

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public int ComunidadeId { get; set; }
        public Comunidade Comunidade { get; set; }

        public Telefone Telefone { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Squad)other).Nome;
            DataInicio = ((Squad)other).DataInicio;
            IdSquad = ((Squad)other).IdSquad;
            GerenteResponsavel = ((Squad)other).GerenteResponsavel;
            GerenteComunidade = ((Squad)other).GerenteComunidade;
        }
    }
}