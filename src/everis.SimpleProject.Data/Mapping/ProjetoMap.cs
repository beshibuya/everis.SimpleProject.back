using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoMap : BaseMapping<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.Property(c => c.DataInicio).IsRequired();
            builder.Property(c => c.EscopoProjeto).IsRequired();
            builder.Property(c => c.EmpresaId).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataPrevista).IsRequired();
            builder.Property(c => c.CentroCusto).IsRequired();
            builder.HasMany(c => c.ProjetosPessoas).WithOne(x => x.Projeto);
        }
    }
}
