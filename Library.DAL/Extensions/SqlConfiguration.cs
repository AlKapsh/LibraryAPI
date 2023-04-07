using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Library.DAL.Extensions
{
    public static class SqlConfiguringuration
    {
        public static void ConfigureSql(this DbContextOptionsBuilder options)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettigs.json")
                .Build();

            options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
            builder => builder.MigrationsAssembly(typeof(SqlConfiguringuration).Assembly.GetName().Name));

        }
    }
}
