using everis.SimpleProject.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoPessoa : Entity
    {
        

        [Required]
        [ForeignKey("IdProjeto")]
        public int IdProjeto { get; set; }
        public Projeto Projeto { get; set; }

        [Required]
        [ForeignKey("IdPessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}