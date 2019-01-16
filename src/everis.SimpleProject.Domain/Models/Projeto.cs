using everis.SimpleProject.Domain.Models.Enums;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Models
{
    public class Projeto : Entity
    {
        public string Nome { get; set; }
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
        public Status Status { get; set; }
        public DateTime DataPrevista { get; set; }
        public string BeneficioEntregue { get; set; }
        public string BeneficioResidual { get; set; }
        public string ProblemasExecucao { get; set; }
        public string Riscos { get; set; }
        public string LicoesAprendidas { get; set; }
        public string CentroCusto { get; set; }
        public List<ProjetoPessoa> ProjetosPessoas { get; set; }

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
            Status = ((Projeto)other).Status;
            DataPrevista = ((Projeto)other).DataPrevista;
            BeneficioEntregue = ((Projeto)other).BeneficioEntregue;
            BeneficioResidual = ((Projeto)other).BeneficioResidual;
            ProblemasExecucao = ((Projeto)other).ProblemasExecucao;
            Riscos = ((Projeto)other).Riscos;
            LicoesAprendidas = ((Projeto)other).LicoesAprendidas;
            CentroCusto = ((Projeto)other).CentroCusto;
            ProjetosPessoas = ((Projeto)other).ProjetosPessoas;
        }
    }
       
}
