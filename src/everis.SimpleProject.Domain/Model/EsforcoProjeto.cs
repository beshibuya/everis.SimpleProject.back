using SimpleProcess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace everis.SimpleProject.Domain.Model
{
    public class EsforcoProjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEsforcoProjeto { get; set; }
        [Required]
        public int IdProjetoPessoa { get; set; }
        public ProjetoPessoa ProjetoPessoa { get; set; }
        [Required]
        public short QtdHorasDia { get; set; }
        [Required]
        public DateTime? DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        [Required]
        public DateTime DataRegistro { get; set; }
    }
}
