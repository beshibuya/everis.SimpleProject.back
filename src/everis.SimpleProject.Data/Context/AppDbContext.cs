using everis.SimpleProject.Data.EF.Mapping;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.EF
{
    public class AppDbContext : DbContext
    {
        #region DBSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Anexo> Anexos { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<Colaborador> Colaboradors { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EsforcoProjeto> EsforcoProjetos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<ProjetoPessoa> ProjetoPessoas { get; set; }
        public DbSet<ProjetoPessoaAtribuicao> ProjetoPessoaAtribuicoes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        #endregion


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
                //optionsBuilder.UseSqlServer("Data Source=sao-h0pjc72;Database=SimpleProcessDB;User ID=admin;Password=#everis01;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UserMap().Configure);
            modelBuilder.Entity<Anexo>(new AnexoMap().Configure);
            modelBuilder.Entity<Change>(new ChangeMap().Configure);
            modelBuilder.Entity<Colaborador>(new ColaboradorMap().Configure);
            modelBuilder.Entity<Empresa>(new EmpresaMap().Configure);
            modelBuilder.Entity<EsforcoProjeto>(new EsforcoProjetoMap().Configure);
            modelBuilder.Entity<Pessoa>(new PessoaMap().Configure);
            modelBuilder.Entity<Projeto>(new ProjetoMap().Configure);
            modelBuilder.Entity<ProjetoPessoa>(new ProjetoPessoaMap().Configure);
            modelBuilder.Entity<ProjetoPessoaAtribuicao>(new ProjetoPessoaAtribuicaoMap().Configure);
            modelBuilder.Entity<Telefone>(new TelefoneMap().Configure);
        }
    }
}
