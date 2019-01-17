using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace everis.SimpleProject.Data.EF
{
    public class AppDbContext : DbContext
    {
        #region DBSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Anexo> Anexos { get; set; }
        public DbSet<SolicitacaoMudanca> Changes { get; set; }
        public DbSet<Colaborador> Colaboradors { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Fase> Fases { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<ProjetoPessoa> ProjetoPessoas { get; set; }
        public DbSet<ProjetoPessoaAtribuicao> ProjetoPessoaAtribuicoes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<AcessoFerramenta> AcessoFerramentas { get; set; }
        public DbSet<Ferramenta> Ferramentas { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TipoFase> TiposFases { get; set; }
        public DbSet<Squad> Squads { get; set; }
        public DbSet<Comunidade> Comunidades { get; set; }
        public DbSet<SquadPessoa> SquadPessoas { get; set; }
        public DbSet<AcessoSigla> AcessoSiglas { get; set; }
        public DbSet<Sigla> Siglas { get; set; }
        public DbSet<PoloAcesso> PoloAcessos { get; set; }
        public DbSet<AreaContratante> AreasContratantes { get; set; }
        public DbSet<DiretoriaContratante> DiretoriasContratantes { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<TipoPessoa> TipoPessoas { get; set; }
        public DbSet<TipoTelefone> TipoTelefones { get; set; }

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var types = Assembly.GetAssembly(typeof(AppDbContext)).GetTypes()
                .Where(
                    w => w.AssemblyQualifiedName.Contains("everis.SimpleProject.Data.EF.Mapping")
                    && !w.IsNestedPrivate
                    && !w.IsAbstract
                    && w.IsPublic);
            foreach(var t  in types)
            {
                dynamic o = Activator.CreateInstance(t);
                modelBuilder.ApplyConfiguration(o);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
