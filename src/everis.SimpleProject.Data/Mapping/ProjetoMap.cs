using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoMap : BaseMapping<Projeto>
    {
        public override void Configure(EntityTypeBuilder<Projeto> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.EscopoProjeto).IsRequired();
            builder.Property(c => c.EmpresaId).IsRequired();
            builder.Property(c => c.StatusId).IsRequired();
            builder.Property(c => c.DataPrevista).IsRequired();
            builder.Property(c => c.CentroCusto).IsRequired();
            builder.Property(c => c.CodigoProjeto).IsRequired(false);
            builder.Property(c => c.StatusId).IsRequired(false).HasDefaultValueSql("1");

            builder.HasOne(o => o.Status).WithMany().HasForeignKey(f => f.StatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Empresa).WithMany().HasForeignKey(f=>f.EmpresaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
