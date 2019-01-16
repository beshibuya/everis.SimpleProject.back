using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class FaseMap : BaseMapping<Fase>
    {
        public override void Configure(EntityTypeBuilder<Fase> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.ProjetoId).IsRequired();
            builder.Property(c => c.PessoaId).IsRequired();
            builder.Property(c => c.TipoFaseId).IsRequired();
            builder.Property(c => c.QtdHorasDia).IsRequired();
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.DataRegistro).IsRequired();
            builder.Property(c => c.Observacao);
            builder.Property(c => c.CodigoFase).IsRequired();

            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey(f => f.ProjetoId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey(f => f.PessoaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.TipoFase).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
