using everis.SimpleProject.Domain.Models.Enums;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Models
{
    public class Colaborador : Entity
    {
        public int FuncaoId { get; set; }
        public Funcao Funcao { get; set; }
        //public int PerfilId { get; set; }
        //public Perfil Perfil { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PoloAcessoId { get; set; }
        public PoloAcesso PoloAcesso { get; set; }
        public int AreaContratanteId { get; set; }
        public AreaContratante AreaContratante { get; set; }
        public int TipoServicoId { get; set; }
        public TipoServico TipoServico { get; set; }
        public string Racf { get; set; }
        public string EmailCorporativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public string NomeMaquina { get; set; }
        public bool Scf { get; set; }
        public bool Clt { get; set; }
        public bool Disponivel { get; set; }
        public string Senha { get; set; }
        public bool OcupacaoFisicaPoloAdm { get; set; }
        public string ContratoSAP { get; set; }
        public bool ExclusivoCliente { get; set; }
        public string TipoContratacao { get; set; }
        public string GestorTecnicoCliente { get; set; }

        public Colaborador()
        {
            Disponivel = true;
            OcupacaoFisicaPoloAdm = false;
            ExclusivoCliente = true;
            TipoContratacao = "Terceirizado";
        }


        public override void MergeFrom(object other)
        {
            Racf = ((Colaborador)other).Racf;
            EmailCorporativo = ((Colaborador)other).EmailCorporativo;
            NomeMaquina = ((Colaborador)other).NomeMaquina;
            FuncaoId = ((Colaborador)other).FuncaoId;
            Funcao = ((Colaborador)other).Funcao;
            Disponivel = ((Colaborador)other).Disponivel;
            Senha = ((Colaborador)other).Senha;
            DataAdmissao = ((Colaborador)other).DataAdmissao;
            DataNascimento = ((Colaborador)other).DataNascimento;
            DataDemissao = ((Colaborador)other).DataDemissao;
            Scf = ((Colaborador)other).Scf;
            Clt = ((Colaborador)other).Clt;
            PoloAcesso = ((Colaborador)other).PoloAcesso;
            AreaContratante = ((Colaborador)other).AreaContratante;
            AreaContratanteId = ((Colaborador)other).AreaContratanteId;
            OcupacaoFisicaPoloAdm = ((Colaborador)other).OcupacaoFisicaPoloAdm;
            ContratoSAP = ((Colaborador)other).ContratoSAP;
            ExclusivoCliente = ((Colaborador)other).ExclusivoCliente;
            TipoContratacao = ((Colaborador)other).TipoContratacao;
            //PerfilId = ((Colaborador)other).PerfilId;
            //Perfil = ((Colaborador)other).Perfil;
        }
    }

}

