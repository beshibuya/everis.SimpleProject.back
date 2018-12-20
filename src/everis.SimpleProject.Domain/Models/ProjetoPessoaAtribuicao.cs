using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoPessoaAtribuicao : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProjetoPessoa { get; set; }

        [Required]
        public int Atribuicao { get; set; }  
    }
}