using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class TipoDemandaMap : BaseMapping<TipoDemanda>
    {

        public override void Configure(EntityTypeBuilder<TipoDemanda> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired();
        }
    }
}