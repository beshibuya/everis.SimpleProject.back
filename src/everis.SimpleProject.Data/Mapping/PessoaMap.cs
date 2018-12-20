using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdPessoa");
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Tipo).IsRequired();
            builder.Property(c => c.Email);
            builder.Property(c => c.Documento);
            builder.Property(c => c.CPF);
            builder.Property(c => c.FotoPath);
            builder.Property(c => c.IdEmpresa).IsRequired();
        }
    }
}
