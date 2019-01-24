using System;

namespace everis.SimpleProject.Domain.Models
{
    public class Squad : Entity
    {
        public string Nome { get; set; }
        public int? Codigo { get; set; }
        public DateTime DataInicio { get; set; }


        public int ComunidadeId { get; set; }
        public Comunidade Comunidade { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Squad)other).Nome;
            DataInicio = ((Squad)other).DataInicio;
        }
    }
}