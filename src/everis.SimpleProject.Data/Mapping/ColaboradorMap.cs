using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdColaborador");
            builder.Property(c => c.Racf);
            builder.Property(c => c.EmailCorp).IsRequired();
            builder.Property(c => c.Funcional).IsRequired();
            builder.Property(c => c.NomeMaquina);
            builder.Property(c => c.Funcao).IsRequired();
            builder.Property(c => c.Perfil).IsRequired();
            builder.Property(c => c.Disponivel).IsRequired();


        }
    }
}
