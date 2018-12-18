using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public short Segmento { get; set; }
    }
}
