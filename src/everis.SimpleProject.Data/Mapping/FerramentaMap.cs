using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class FerramentaMap : BaseMapping<Ferramenta>
    {
        public override void Configure(EntityTypeBuilder<Ferramenta> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Descricao).IsRequired();
            
        }
    }
}
