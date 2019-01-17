using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class AtribuicaoMap : BaseMapping<Atribuicao>
    {
        public override void Configure(EntityTypeBuilder<Atribuicao> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Codigo).IsRequired();
            builder.Property(c => c.Descricao).IsRequired();

        }
    }
}
