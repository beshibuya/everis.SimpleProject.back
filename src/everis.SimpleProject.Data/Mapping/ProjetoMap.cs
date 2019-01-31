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
            builder.Property(c => c.CodigoProjeto).IsRequired();
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.EmpresaId).IsRequired();
            builder.Property(c => c.StatusId).IsRequired();
            builder.Property(c => c.DataRecebida).IsRequired();
            builder.Property(c => c.TipoDemanda).IsRequired();
            builder.Property(c => c.Tamanho).IsRequired();
            builder.Property(c => c.DiretoriaId).IsRequired();
            builder.Property(c => c.TecnologiaId).IsRequired();
            builder.Property(c => c.SuperintendenciaId).IsRequired();
            
            builder.HasOne(o => o.Status).WithMany().HasForeignKey(f => f.StatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Diretoria).WithMany().HasForeignKey(f => f.DiretoriaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Empresa).WithMany().HasForeignKey(f=>f.EmpresaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
