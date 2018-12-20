using System;

namespace everis.SimpleProject.Domain.Models
{
    public class EsforcoProjeto : Entity
    {
   
        public int IdProjetoPessoa { get; set; }
        public ProjetoPessoa ProjetoPessoa { get; set; }
        public short QtdHorasDia { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime DataRegistro { get; set; }

        public override void MergeFrom(object other)
        {
            QtdHorasDia = ((EsforcoProjeto)other).QtdHorasDia;
            DataFim = ((EsforcoProjeto)other).DataFim;
            DataInicio = ((EsforcoProjeto)other).DataInicio;
        }
    }
}
