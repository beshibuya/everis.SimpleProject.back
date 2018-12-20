﻿using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class UserMap : BaseMapping<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(c => c.NomeUsuario).IsRequired();
            builder.Property(c => c.Senha).IsRequired().HasMaxLength(255);
            builder.Property(c => c.SenhaTemporaria).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.DataCadastro).IsRequired();
        }
    }
}
