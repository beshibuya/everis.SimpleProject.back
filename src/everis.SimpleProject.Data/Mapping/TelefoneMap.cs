using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{

    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdTelefone");
            builder.Property(c => c.NumeroTelefone).IsRequired();
            builder.Property(c => c.Tipo).IsRequired();
            builder.Property(c => c.IdPessoa).IsRequired();


        }
    }
}
