using everis.SimpleProject.Domain.Models.Enums;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Models
{
    public class Projeto : Entity
    {
        public string Nome { get; set; }
        public string CodigoProjeto { get; set; }
        public int QtdHorasServico1 { get; set; }
        public int QtdHorasServico2 { get; set; }
        public int QtdHorasServico3 { get; set; }
        public DateTime? DataInicio { get; set; }
        public string EscopoProjeto { get; set; }
        public string ForaEscopoProjeto { get; set; }
        public string Premissas { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public int? StatusId { get; set; }
        public Status Status { get; set; }
        public DateTime? DataFinal { get; set; }
        public DateTime? DataProposta { get; set; }
        public string StatusProposta { get; set; }
        public string BeneficioEntregue { get; set; }
        public string BeneficioResidual { get; set; }
        public string ProblemasExecucao { get; set; }
        public string Riscos { get; set; }
        public string LicoesAprendidas { get; set; }
        //public string Ext { get; set; }
        public int? ExtId { get; set; }
        public Exts Ext { get; set; }
        public DateTime DataRecebida { get; set; }
        //public Sigla Sigla { get; set; }
        //public int SiglaId { get; set; }
        public int DiretoriaId { get; set; }
        public DiretoriaContratante Diretoria { get; set; }
        public char Tamanho { get; set; }
        public string TipoDemanda { get; set; }
        public decimal Tarifa { get; set; }
        public int SuperintendenciaId { get; set; }
        public Superintendencia Superintendencia { get; set; }
        public int? SquadId { get; set; }
        public Squad Squad { get; set; }
        public int Duracao { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Projeto)other).Nome;
            QtdHorasServico1 = ((Projeto)other).QtdHorasServico1;
            QtdHorasServico2 = ((Projeto)other).QtdHorasServico2;
            QtdHorasServico3 = ((Projeto)other).QtdHorasServico3;
            DataInicio = ((Projeto)other).DataInicio;
            EscopoProjeto = ((Projeto)other).EscopoProjeto;
            ForaEscopoProjeto = ((Projeto)other).ForaEscopoProjeto;
            Premissas = ((Projeto)other).Premissas;
            DataFinal = ((Projeto)other).DataFinal;
            BeneficioEntregue = ((Projeto)other).BeneficioEntregue;
            BeneficioResidual = ((Projeto)other).BeneficioResidual;
            ProblemasExecucao = ((Projeto)other).ProblemasExecucao;
            Riscos = ((Projeto)other).Riscos;
            LicoesAprendidas = ((Projeto)other).LicoesAprendidas;
            ExtId = ((Projeto)other).ExtId;
            DataRecebida = ((Projeto)other).DataRecebida;
            CodigoProjeto = ((Projeto)other).CodigoProjeto;
            DiretoriaId = ((Projeto)other).DiretoriaId;
            Tamanho = ((Projeto)other).Tamanho;
            TipoDemanda = ((Projeto)other).TipoDemanda;
            Tarifa = ((Projeto)other).Tarifa;
            SuperintendenciaId = ((Projeto)other).SuperintendenciaId;
            DataProposta = ((Projeto)other).DataProposta;
            StatusProposta = ((Projeto)other).StatusProposta;
            SquadId = ((Projeto)other).SquadId;
            Duracao = ((Projeto)other).Duracao;
            StatusId = ((Projeto)other).StatusId;
        }
    }
       
}
