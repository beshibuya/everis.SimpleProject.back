using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{

    public class TelefoneMap : BaseMapping<Telefone>
    {
        public override void Configure(EntityTypeBuilder<Telefone> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.NumeroTelefone).IsRequired();
            builder.Property(c => c.TipoTelefone).IsRequired();
            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey(f => f.PessoaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
