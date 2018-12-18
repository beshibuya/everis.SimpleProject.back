using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class Change
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdChange { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public short HorasImpacto { get; set; }

        [Required]
        public DateTime DataHoraCadastro { get; set; }
    }
}
