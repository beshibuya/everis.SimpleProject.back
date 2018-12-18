using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class ProjetoPessoaAtribuicao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProjetoPessoa { get; set; }

        [Required]
        public int Atribuicao { get; set; }  
    }
}