using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Model
{
    class ProjetoModel
    {
        public int IdProjeto { get; set; }
        public string Nome { get; set; }
        public int QtdHorasServico1 { get; set; }
        public int QtdHorasServico2 { get; set; }
        public int QtdHorasServico3 { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataEntrega { get; set; }
        public String EscopoProjeto { get; set; }
        public string ForaEscopoProjeto { get; set; }
        public string Premissas { get; set; }
        public int IdEmpresa { get; set; }
        public short Status { get; set; }
        public DateTime DataPrevista { get; set; }
        public string BeneficioEntregue { get; set; }
        public string BeneficioResidual { get; set; }
        public string ProblemasExecucao { get; set; }
        public string Riscos { get; set; }
        public string LicoesAprendidas { get; set; }

    }
        public enum Status
        {
            EmExecucao = 1,
            Concluido = 2,
            Cancelado = 3,
            Congelado = 4,
            PendenteCliente = 5,
            ControleQualidade = 6
        }
}
