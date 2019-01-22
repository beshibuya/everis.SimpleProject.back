using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class SuperintendenciaMap : BaseMapping<Superintendencia>
    {
        public override void Configure(EntityTypeBuilder<Superintendencia> builder)
        {
            base.Configure(builder);
        }
    }
}
