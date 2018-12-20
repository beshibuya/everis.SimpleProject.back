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
            var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SimpleProjectDB;Integrated Security=True";
            builder.UseSqlServer(connString);
            return new AppDbContext(builder.Options);
        }
    }
}
