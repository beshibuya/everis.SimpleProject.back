using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoPessoaAtribuicao : Entity
    {
        [Required]
        [ForeignKey("IdProjetoPessoa")]
        public int IdProjetoPessoa { get; set; }
        public ProjetoPessoa ProjetoPessoa { get; set; }

        [Required]
        public int Atribuicao { get; set; }  
    }
}