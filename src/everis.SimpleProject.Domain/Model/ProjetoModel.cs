using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace everis.SimpleProject.Domain.Model
{
    class ProjetoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProjeto { get; set; }
        [Required]
        public string Nome { get; set; }
        public int QtdHorasServico1 { get; set; }
        public int QtdHorasServico2 { get; set; }
        public int QtdHorasServico3 { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        public DateTime DataEntrega { get; set; }
        [Required]
        public String EscopoProjeto { get; set; }
        public string ForaEscopoProjeto { get; set; }
        public string Premissas { get; set; }
        public int IdEmpresa { get; set; }
        [Required]
        public short Status { get; set; }
        [Required]
        public DateTime DataPrevista { get; set; }
        public string BeneficioEntregue { get; set; }
        public string BeneficioResidual { get; set; }
        public string ProblemasExecucao { get; set; }
        public string Riscos { get; set; }
        public string LicoesAprendidas { get; set; }
        [Required]
        public string CentroCusto { get; set; }

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
