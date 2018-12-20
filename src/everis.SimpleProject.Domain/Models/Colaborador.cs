using everis.SimpleProject.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace everis.SimpleProject.Domain.Models
{
    public class Colaborador : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdColaborador { get; set; }

        [Required]
        public int IdPessoa { get; set; }

        [Required]
        public Pessoa Pessoa { get; set; }

        public string Racf { get; set; }

        [Required]
        public string EmailCorp { get; set; }

        [Required]
        public int Funcional { get; set; }

        public string NomeMaquina { get; set; }

        [Required]
        public eFuncao Funcao { get; set; }

        [Required]
        public ePerfil Perfil { get; set; }

        [Required]
        public bool Disponivel { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }

}

