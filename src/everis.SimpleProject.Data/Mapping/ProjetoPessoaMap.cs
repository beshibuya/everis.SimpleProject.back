using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{

    public class ProjetoPessoaMap : IEntityTypeConfiguration<ProjetoPessoa>
    {
        public void Configure(EntityTypeBuilder<ProjetoPessoa> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdProjetoPessoa");
            builder.Property(c => c.IdProjeto).IsRequired();
            builder.Property(c => c.IdPessoa).IsRequired();
            builder.Property(c => c.DataInativacao);

        }
    }
}
