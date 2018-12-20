using everis.SimpleProject.Domain.Models.Enums;
using everis.SimpleProject.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{

    public class Anexo : Entity
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
