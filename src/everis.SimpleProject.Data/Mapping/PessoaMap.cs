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
            //builder.HasKey(c => c.Id);
            //builder.Property(c => c.Id).HasColumnName("IdUsuario");
            //builder.Property(c => c.NomeUsuario).IsRequired();
            //builder.Property(c => c.Senha).IsRequired();
            //builder.Property(c => c.SenhaTemporaria).IsRequired();
            //builder.Property(c => c.Email).IsRequired();
            //builder.Property(c => c.DataCadastro).IsRequired();
            //builder.Property(c => c.DataDesativacao);


        }
    }
}
