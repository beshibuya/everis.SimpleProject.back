using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class Telefone : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTelefone { get; set; }

        [Required]
        public string NumeroTelefone { get; set; }

        [Required]
        public short Tipo { get; set; }

        [ForeignKey("IdPessoa")]
        [Required]
        public int IdPessoa { get; set; }

        [Required]
        public Pessoa Pessoa { get; set; }
    }
}
