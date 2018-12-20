using everis.SimpleProject.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class Pessoa : Entity
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public eTipoPessoa Tipo { get; set; }

        public string Email { get; set; }

        public string Documento { get; set; }

        public long CPF { get; set; }
        
        public string FotoPath { get; set; }

        [Required]
        [ForeignKey("IdEmpresa")]
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }

    }
}
