using everis.SimpleProject.Domain.Models.Enums;
using everis.SimpleProject.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{

    public class Anexo : Entity
    {
        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public eTipoAnexo Tipo { get; set; }

        [Required]
        [ForeignKey("IdProjeto")]
        public int IdProjeto { get; set; }
        public Projeto Projeto { get; set; }     
    }
}
