using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class EsforcoProjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEsforcoProjeto { get; set; }

        [Required]
        public int IdProjetoPessoa { get; set; }

        [Required]
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
