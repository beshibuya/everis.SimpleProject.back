using System;

namespace everis.SimpleProject.Domain.Models
{
    public class Fase : Entity
    {
   
        public int ProjetoPessoaId { get; set; }
        public ProjetoPessoa ProjetoPessoa { get; set; }
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
            QtdHorasDia = ((Fase)other).QtdHorasDia;
            DataFim = ((Fase)other).DataFim;
            DataInicio = ((Fase)other).DataInicio;
        }
    }
}
