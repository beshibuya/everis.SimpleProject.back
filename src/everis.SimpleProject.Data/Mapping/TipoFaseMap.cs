using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class TipoFaseMap : BaseMapping<TipoFase>
    {
        public override void Configure(EntityTypeBuilder<TipoFase> b)
        {
            base.Configure(b);
            b.Property(c => c.Nome).IsRequired();
        }
    }
}
