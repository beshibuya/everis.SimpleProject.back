using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class PessoaMap : BaseMapping<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Tipo).IsRequired();
            builder.Property(c => c.IdEmpresa).IsRequired();
        }
    }
}
