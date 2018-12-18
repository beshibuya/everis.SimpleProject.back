using everis.SimpleProject.Domain.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{

    public class Anexo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAnexo { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public eTipoAnexo Tipo { get; set; }

        [Required]
        public int IdProjeto { get; set; }   // FK 
        public Projeto Projeto { get; set; }  // FK     
    }
}
