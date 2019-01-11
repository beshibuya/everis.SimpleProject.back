using System;

namespace everis.SimpleProject.Domain.Models
{
    public class SolicitacaoMudanca : Entity
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
            Descricao = ((SolicitacaoMudanca)other).Descricao;
            QtdHorasServico1 = ((SolicitacaoMudanca)other).QtdHorasServico1;
            QtdHorasServico2 = ((SolicitacaoMudanca)other).QtdHorasServico2;
            QtdHorasServico3 = ((SolicitacaoMudanca)other).QtdHorasServico3;

        }
    }
}
