using everis.SimpleProject.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace everis.SimpleProject.API.Config
{
    public static class RepositoryConfig
    {
        public static void Configure(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = Environment.GetEnvironmentVariable("SimpleProcessConnString");
            services.AddDbContext<AppDbContext>(
                o => o.UseSqlServer(connString));
        }
    }
}
