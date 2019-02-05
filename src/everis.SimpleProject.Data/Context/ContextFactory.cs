using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace everis.SimpleProject.Data.EF.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder().Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connString = "Data Source=SAO-3J40BB2\\SQLEXPRESS;Initial Catalog=SimpleProjectDB;Integrated Security=False;User ID=SimpleProcess;Password=simplepwd123";
            builder.UseSqlServer(connString);
            return new AppDbContext(builder.Options);
        }
    }
}
