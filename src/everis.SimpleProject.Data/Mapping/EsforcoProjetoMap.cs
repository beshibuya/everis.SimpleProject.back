using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class EsforcoProjetoMap : IEntityTypeConfiguration<EsforcoProjeto>
    {
        public void Configure(EntityTypeBuilder<EsforcoProjeto> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdEsforcoProjeto");
            builder.Property(c => c.IdProjetoPessoa).IsRequired();
            builder.Property(c => c.QtdHorasDia).IsRequired();
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.DataFim);
            builder.Property(c => c.DataRegistro).IsRequired();
            builder.Property(c => c.DataInativacao);


        }
    }
}
