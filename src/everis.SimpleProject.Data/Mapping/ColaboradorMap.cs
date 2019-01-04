using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ColaboradorMap : BaseMapping<Colaborador>
    {
        public override void Configure(EntityTypeBuilder<Colaborador> builder)
        {

            base.Configure(builder);
            builder.Property(c => c.EmailCorporativo).IsRequired();
            builder.Property(c => c.Funcional).IsRequired();
            builder.Property(c => c.Funcao).IsRequired();
            //builder.Property(c => c.Perfil).IsRequired();
            builder.Property(c => c.Disponivel).IsRequired();

            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey(f => f.PessoaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
