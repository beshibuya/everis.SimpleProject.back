using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class AcessoFerramentaMap : BaseMapping<AcessoFerramenta>
    {
        public override void Configure(EntityTypeBuilder<AcessoFerramenta> builder)
        {
            base.Configure(builder);
            builder.HasOne(c => c.Ferramenta);
            builder.HasOne(o => o.Colaborador).WithMany(o => o.Acessos).IsRequired().OnDelete(DeleteBehavior.Restrict);


        }
    }
}
