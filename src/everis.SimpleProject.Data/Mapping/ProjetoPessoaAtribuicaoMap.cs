﻿using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoPessoaAtribuicaoMap : BaseMapping<ProjetoPessoaAtribuicao>
    {
        public override void Configure(EntityTypeBuilder<ProjetoPessoaAtribuicao> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Atribuicao).IsRequired();

        }
    }
}
