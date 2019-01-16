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
            builder.Property(c => c.Funcao).IsRequired();
            builder.Property(c => c.Disponivel).IsRequired();
            builder.HasMany(c => c.Acessos).WithOne(x => x.Colaborador);
            builder.HasOne(c => c.PoloAcesso).WithMany().HasForeignKey(f => f.PoloAcessoId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.DiretoriaContratante).WithMany().HasForeignKey(f => f.DiretoriaContratanteId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.AreaContratante).WithMany().HasForeignKey(f => f.AreaContratanteId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.TipoServico).WithMany().HasForeignKey(f => f.TipoServicoId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
