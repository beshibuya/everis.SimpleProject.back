using everis.SimpleProject.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class EsforcoProjeto : Entity
    {
   
        [Required]
        [ForeignKey("IdProjetoPessoa")]
        public int IdProjetoPessoa { get; set; }
        public ProjetoPessoa ProjetoPessoa { get; set; }

        [Required]
        public short QtdHorasDia { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        [Required]
        public DateTime DataRegistro { get; set; }
    }
}
