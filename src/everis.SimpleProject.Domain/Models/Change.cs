using System;

namespace everis.SimpleProject.Domain.Models
{
    public class Change : Entity
    {
        public string Descricao { get; set; }
        public short HorasImpacto { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }

        public override void MergeFrom(object other)
        {
            Descricao = ((Change)other).Descricao;
            HorasImpacto = ((Change)other).HorasImpacto;
        }
    }
}
