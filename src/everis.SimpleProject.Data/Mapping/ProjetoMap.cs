using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoMap : BaseMapping<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.EscopoProjeto).IsRequired();
            builder.Property(c => c.EmpresaId).IsRequired();
            builder.Property(c => c.Status).HasColumnType("int").IsRequired(); ;
            builder.Property(c => c.DataPrevista).IsRequired();
            builder.Property(c => c.CentroCusto).IsRequired();

            builder.HasOne(o => o.Empresa).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(o => o.ProjetosPessoas).WithOne().HasForeignKey().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
