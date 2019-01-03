using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class EsforcoProjetoMap : BaseMapping<EsforcoProjeto>
    {
        public override void Configure(EntityTypeBuilder<EsforcoProjeto> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.ProjetoPessoaId).IsRequired();
            builder.Property(c => c.QtdHorasDia).IsRequired();
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.DataRegistro).IsRequired();

            builder.HasOne(o => o.ProjetoPessoa).WithMany().HasForeignKey(f => f.ProjetoPessoaId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
