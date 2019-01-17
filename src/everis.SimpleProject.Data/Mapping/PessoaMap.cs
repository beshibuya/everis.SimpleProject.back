using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class PessoaMap : BaseMapping<Pessoa>
    {
        public override void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired();
            //builder.Property(c => c.EmpresaId).IsRequired();
            //builder.HasOne(o => o.Colaborador);
            builder.Property(c => c.Sexo).IsRequired();
            //builder.HasOne(o => o.Colaborador); //TODO: está linha não está causando duplicidade?
            //builder.HasOne(o => o.Colaborador).WithMany().HasForeignKey(f => f.ColaboradorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.Diretoria).WithMany().HasForeignKey(f => f.DiretoriaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.Tipo).WithMany().HasForeignKey(f => f.TipoId).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
