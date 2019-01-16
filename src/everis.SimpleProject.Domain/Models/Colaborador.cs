using everis.SimpleProject.Domain.Models.Enums;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Models
{
    public class Colaborador : Entity
    {
        public int PoloAcessoId { get; set; }
        public PoloAcesso PoloAcesso { get; set; }
        public int AreaContratanteId { get; set; }
        public AreaContratante AreaContratante { get; set; }
        public int DiretoriaContratanteId { get; set; }
        public DiretoriaContratante DiretoriaContratante { get; set; }
        public int TipoServicoId { get; set; }
        public TipoServico TipoServico { get; set; }
        public List<AcessoFerramenta> Acessos { get; set; }
        public string UserId { get; set; }
        public string Racf { get; set; }
        public string EmailCorporativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissão { get; set; }
        public DateTime DataDemissao { get; set; }
        public string NomeMaquina { get; set; }
        public bool Scf { get; set; }
        public bool Clt { get; set; }
        public Funcao Funcao { get; set; }
        public Perfil Perfil { get; set; }
        public bool Disponivel { get; set; }
        public string Senha { get; set; }
        public bool OcupacaoFisicaPoloAdm { get; set; }
        public string ContratoSAP { get; set; }
        public bool ExclusivoItau { get; set; }
        public string TipoContratacao { get; set; }

        public Colaborador()
        {
            Disponivel = true;
            OcupacaoFisicaPoloAdm = false;
            ExclusivoItau = true;
            TipoContratacao = "Terceirizado";
        }


        public override void MergeFrom(object other)
        {
            Racf = ((Colaborador)other).Racf;
            EmailCorporativo = ((Colaborador)other).EmailCorporativo;
            NomeMaquina = ((Colaborador)other).NomeMaquina;
            Perfil = ((Colaborador)other).Perfil;
            Funcao = ((Colaborador)other).Funcao;
            Disponivel = ((Colaborador)other).Disponivel;
            Senha = ((Colaborador)other).Senha;
            Acessos = ((Colaborador)other).Acessos;
            DataAdmissão = ((Colaborador)other).DataAdmissão;
            DataNascimento = ((Colaborador)other).DataNascimento;
            DataDemissao = ((Colaborador)other).DataDemissao;
            Scf = ((Colaborador)other).Scf;
            Clt = ((Colaborador)other).Clt;
            UserId = ((Colaborador)other).UserId;
            PoloAcesso = ((Colaborador)other).PoloAcesso;
            AreaContratante = ((Colaborador)other).AreaContratante;
            AreaContratanteId = ((Colaborador)other).AreaContratanteId;
            OcupacaoFisicaPoloAdm = ((Colaborador)other).OcupacaoFisicaPoloAdm;
            ContratoSAP = ((Colaborador)other).ContratoSAP;
            ExclusivoItau = ((Colaborador)other).ExclusivoItau;
            TipoContratacao = ((Colaborador)other).TipoContratacao;
        }
    }

}

