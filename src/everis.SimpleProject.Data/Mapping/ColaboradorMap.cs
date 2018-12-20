﻿using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ColaboradorMap : BaseMapping<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.Property(c => c.EmailCorporativo).IsRequired();
            builder.Property(c => c.Funcional).IsRequired();
            builder.Property(c => c.Funcao).IsRequired();
            builder.Property(c => c.Perfil).IsRequired();
            builder.Property(c => c.Disponivel).IsRequired();

            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
