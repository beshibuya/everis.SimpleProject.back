using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class TecnologiaMap : BaseMapping<Tecnologia>
    {
        public override void Configure(EntityTypeBuilder<Tecnologia> builder)
        {
            base.Configure(builder);
        }
    }
}
