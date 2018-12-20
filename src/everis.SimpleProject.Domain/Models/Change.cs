using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class Change : Entity
    {
        [Required]
        public string Descricao { get; set; }

        [Required]
        public short HorasImpacto { get; set; }

        [Required]
        public DateTime DataHoraCadastro { get; set; }

        [ForeignKey("IdProjeto")]
        [Required]
        public int IdProjeto { get; set; }
        public Projeto Projeto { get; set; }
    }
}
