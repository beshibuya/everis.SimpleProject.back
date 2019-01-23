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
            builder.Property(c => c.Ext).IsRequired();
            builder.Property(c => c.DataRecebida).IsRequired();
            builder.Property(c => c.Tecnologia).IsRequired();
            builder.Property(c => c.Sigla).IsRequired();
            builder.Property(c => c.RespOutsourcing).IsRequired();
            builder.Property(c => c.RespTI).IsRequired();
            builder.Property(c => c.RespGerente).IsRequired();
            builder.Property(c => c.Tamanho).IsRequired();
            builder.Property(c => c.TipoDemanda).IsRequired();
            builder.Property(c => c.Tarifa).IsRequired();
            builder.Property(c => c.Superintendencia).IsRequired();
            builder.Property(c => c.DataProposta).IsRequired();
            builder.Property(c => c.StatusProposta).IsRequired();
            





            builder.HasOne(o => o.Status).WithMany().HasForeignKey(f => f.StatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Diretoria).WithMany().HasForeignKey(f => f.DiretoriaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Empresa).WithMany().HasForeignKey(f=>f.EmpresaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
