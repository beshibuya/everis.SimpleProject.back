using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoPessoaAtribuicaoMap : IEntityTypeConfiguration<ProjetoPessoaAtribuicao>
    {
        public void Configure(EntityTypeBuilder<ProjetoPessoaAtribuicao> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdProjetoPessoaAtribuicao");
            builder.Property(c => c.IdProjetoPessoa).IsRequired();
            builder.Property(c => c.Atribuicao).IsRequired();
            builder.Property(c => c.DataInativacao);

        }
    }
}
