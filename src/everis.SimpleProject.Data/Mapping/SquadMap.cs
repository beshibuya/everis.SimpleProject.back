using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class SquadMap : BaseMapping<Squad>
    {
        public override void Configure(EntityTypeBuilder<Squad> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.IdSquad).IsRequired();
            builder.Property(c => c.GerenteResponsavel).IsRequired(); ;
            builder.Property(c => c.GerenteComunidade).IsRequired();

            builder.HasOne(o => o.Comunidade).WithMany().HasForeignKey(f => f.ComunidadeId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}