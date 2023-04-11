using Library.DAL.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Extensions
{
    public static class SqlConfiguring
    {
        public static void ConfigureSql(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationLibraryContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                builder => builder.MigrationsAssembly(typeof(SqlConfiguringuration).Assembly.GetName().Name))
            );

        }
    }
}
