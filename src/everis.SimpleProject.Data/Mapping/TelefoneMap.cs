using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{

    public class TelefoneMap : BaseMapping<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.Property(c => c.NumeroTelefone).IsRequired();
            builder.Property(c => c.TipoTelefone).IsRequired();
            builder.Property(c => c.PessoaId).IsRequired();
            builder.HasOne(o=>o.Pessoa).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
