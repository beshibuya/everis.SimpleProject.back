using everis.SimpleProject.Domain.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPessoa { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public eTipoPessoa Tipo { get; set; }

        public string Email { get; set; }

        public string Documento { get; set; }

        public long CPF { get; set; }

        [Required]
        public bool Ativo { get; set; }

        public string FotoPath { get; set; }

        [Required]
        public int IdEmpresa { get; set; }  // FK 

        [Required]
        public Empresa Empresa { get; set; } // FK 

    }
}
