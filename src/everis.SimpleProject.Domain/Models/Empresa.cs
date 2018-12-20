using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class Empresa : Entity
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public short Segmento { get; set; }
    }
}
