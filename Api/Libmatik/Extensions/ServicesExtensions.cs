using Microsoft.EntityFrameworkCore;
using Repositories.EFCore;
using System;

namespace Api.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<RepositoryContext>(options => options.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString)));
        }
    }
}
