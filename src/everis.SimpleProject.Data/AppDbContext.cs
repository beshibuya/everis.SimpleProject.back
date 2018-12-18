using everis.SimpleProject.Data.EF.Configuration;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.EF
{
    public class AppDbContext : DbContext
    {
        #region DBSets
        DbSet<Usuario> Usuarios { get; set; }
        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
