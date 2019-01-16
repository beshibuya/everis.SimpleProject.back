using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ComunidadeMap : BaseMapping<Comunidade>
    {
        public override void Configure(EntityTypeBuilder<Comunidade> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired();
        }
    }
}
