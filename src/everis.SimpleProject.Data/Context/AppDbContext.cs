using everis.SimpleProject.Data.EF.Configuration;
using everis.SimpleProject.Data.EF.Mapping;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.EF
{
    public class AppDbContext : DbContext
    {
        #region DBSets
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UserMap().Configure);
        }
    }
}
