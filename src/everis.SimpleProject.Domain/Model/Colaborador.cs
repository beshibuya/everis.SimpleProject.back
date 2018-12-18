using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace everis.SimpleProject.Domain.Model
{
    public class Colaborador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdColaborador { get; set; }

        public int IdPessoa { get; set; }

        public Pessoa pessoa { get; set; }

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

    public enum eFuncao
    {
        SA = 1,
        SN = 2,
        STL = 3,
        SPL = 4,
        SK = 5,
        SKL = 6,
        Manager = 7
    }

    public enum ePerfil
    {
        Master = 1,
        Lider = 2,
        Colaborador = 3

    }

}

