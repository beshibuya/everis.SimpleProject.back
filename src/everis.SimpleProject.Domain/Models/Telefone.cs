using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class Telefone : Entity
    {
        [Required]
        public string NumeroTelefone { get; set; }

        [Required]
        public short Tipo { get; set; }

        [Required]
        [ForeignKey("IdPessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
