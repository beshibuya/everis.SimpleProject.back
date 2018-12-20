using everis.SimpleProject.Domain.Models.Enums;


namespace everis.SimpleProject.Domain.Models
{
    public class Colaborador : Entity
    {
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        public string Racf { get; set; }
        public string EmailCorporativo { get; set; }

        public int Funcional { get; set; }
        public string NomeMaquina { get; set; }

        public eFuncao Funcao { get; set; }
        public ePerfil Perfil { get; set; }
        public bool Disponivel { get; set; }
        public string Senha { get; set; }

        public override void MergeFrom(object other)
        {
            Racf = ((Colaborador)other).Racf;
            EmailCorporativo = ((Colaborador)other).EmailCorporativo;
            NomeMaquina = ((Colaborador)other).NomeMaquina;
            Funcional = ((Colaborador)other).Funcional;
            Perfil = ((Colaborador)other).Perfil;
            Funcao = ((Colaborador)other).Funcao;
            Disponivel = ((Colaborador)other).Disponivel;
            Senha = ((Colaborador)other).Senha;
        }
    }

}

