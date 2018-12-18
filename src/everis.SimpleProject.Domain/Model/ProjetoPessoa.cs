using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class ProjetoPessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProjetoPessoa { get; set; }

        [ForeignKey("IdProjeto")]
        public int IdProjeto { get; set; }
        public Projeto Projeto { get; set; }

        [ForeignKey("IdPessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}