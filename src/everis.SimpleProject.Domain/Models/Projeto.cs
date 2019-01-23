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
        public DateTime DataInicio { get; set; }
        public DateTime DataEntrega { get; set; }
        public string EscopoProjeto { get; set; }
        public string ForaEscopoProjeto { get; set; }
        public string Premissas { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public int? StatusId { get; set; }
        public Status Status { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataProposta { get; set; }
        public string StatusProposta { get; set; }
        public string BeneficioEntregue { get; set; }
        public string BeneficioResidual { get; set; }
        public string ProblemasExecucao { get; set; }
        public string Riscos { get; set; }
        public string LicoesAprendidas { get; set; }
        public string Ext { get; set; }
        public List<ProjetoPessoa> ProjetosPessoas { get; set; }
        public DateTime DataRecebida { get; set; }
        public string Tecnologia { get; set; }    
        public string TecnologiaId { get; set; }
        public string Sigla { get; set; }
        public string RespOutsourcing { get; set; }
        public string RespTI { get; set; }
        public string RespGerente { get; set; }
        public int DiretoriaId { get; set; }
        public DiretoriaContratante Diretoria { get; set; }
        public char Tamanho { get; set; }
        public string TipoDemanda { get; set; }
        public string Tarifa { get; set; }
        public string SuperintendenciaId { get; set; }
        public string Superintendencia { get; set; }
        

        public int? SquadId { get; set; }
        public Squad Squad { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Projeto)other).Nome;
            QtdHorasServico1 = ((Projeto)other).QtdHorasServico1;
            QtdHorasServico2 = ((Projeto)other).QtdHorasServico2;
            QtdHorasServico3 = ((Projeto)other).QtdHorasServico3;
            DataInicio = ((Projeto)other).DataInicio;
            DataEntrega = ((Projeto)other).DataEntrega;
            EscopoProjeto = ((Projeto)other).EscopoProjeto;
            ForaEscopoProjeto = ((Projeto)other).ForaEscopoProjeto;
            Premissas = ((Projeto)other).Premissas;
            DataPrevista = ((Projeto)other).DataPrevista;
            BeneficioEntregue = ((Projeto)other).BeneficioEntregue;
            BeneficioResidual = ((Projeto)other).BeneficioResidual;
            ProblemasExecucao = ((Projeto)other).ProblemasExecucao;
            Riscos = ((Projeto)other).Riscos;
            LicoesAprendidas = ((Projeto)other).LicoesAprendidas;
            Ext = ((Projeto)other).Ext;
            ProjetosPessoas = ((Projeto)other).ProjetosPessoas;
            DataRecebida = ((Projeto)other).DataRecebida;
            CodigoProjeto = ((Projeto)other).CodigoProjeto;
            Tecnologia = ((Projeto)other).Tecnologia;
            Sigla = ((Projeto)other).Sigla;
            RespOutsourcing = ((Projeto)other).RespOutsourcing;
            RespTI = ((Projeto)other).RespTI;
            RespGerente = ((Projeto)other).RespGerente;
            Diretoria = ((Projeto)other).Diretoria;
            Tamanho = ((Projeto)other).Tamanho;
            TipoDemanda = ((Projeto)other).TipoDemanda;
            Tarifa = ((Projeto)other).Tarifa;
            Superintendencia = ((Projeto)other).Superintendencia;
            DataProposta = ((Projeto)other).DataProposta;
            StatusProposta = ((Projeto)other).StatusProposta;
            


            StatusId = ((Projeto)other).StatusId;
        }
    }
       
}
