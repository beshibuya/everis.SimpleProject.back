using System;

namespace everis.SimpleProject.Domain.Models
{
    public class Change : Entity
    {
        public string Descricao { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public int QtdHorasServico1 { get; set; }
        public int QtdHorasServico2 { get; set; }
        public int QtdHorasServico3 { get; set; }

        public override void MergeFrom(object other)
        {
            Descricao = ((Change)other).Descricao;
            QtdHorasServico1 = ((Change)other).QtdHorasServico1;
            QtdHorasServico2 = ((Change)other).QtdHorasServico2;
            QtdHorasServico3 = ((Change)other).QtdHorasServico3;

        }
    }
}
