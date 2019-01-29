using System;

namespace everis.SimpleProject.Domain.Models
{
    public class Fase : Entity
    {
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int TipoFaseId { get; set; }
        public TipoFase TipoFase { get; set; }
        public short QtdHorasDia { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Observacao { get; set; }
        public int CodigoFase { get; set; }
        public DateTime DataRegistro { get; set; }

        public override void MergeFrom(object other)
        {
            TipoFaseId = ((Fase)other).TipoFaseId;
            PessoaId = ((Fase)other).PessoaId;
            QtdHorasDia = ((Fase)other).QtdHorasDia;
            DataFim = ((Fase)other).DataFim;
            DataInicio = ((Fase)other).DataInicio;
            Observacao = ((Fase)other).Observacao;
            CodigoFase = ((Fase)other).CodigoFase;
        }
    }
}
