using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoMap : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdProjeto");
            builder.Property(c => c.QtdHorasServico1);
            builder.Property(c => c.QtdHorasServico2);
            builder.Property(c => c.QtdHorasServico3);
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.EscopoProjeto).IsRequired();
            builder.Property(c => c.DataEntrega);
            builder.Property(c => c.ForaEscopoProjeto);
            builder.Property(c => c.Premissas);
            builder.Property(c => c.IdEmpresa).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataPrevista).IsRequired();
            builder.Property(c => c.CentroCusto).IsRequired();
            builder.Property(c => c.BeneficioEntregue);
            builder.Property(c => c.BeneficioResidual);
            builder.Property(c => c.ProblemasExecucao);
            builder.Property(c => c.Riscos);
            builder.Property(c => c.LicoesAprendidas);
            builder.Property(c => c.DataInativacao);


        }
    }
}
