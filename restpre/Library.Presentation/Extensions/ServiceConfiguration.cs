using Library.DAL.Contracts;
using Library.BAL.Contracts;
using Library.DAL.Extensions;
using Library.DAL.Repository;
using System.Runtime.CompilerServices;
using Library.BAL.Services;
using Library.BAL.Extensions;

namespace LibraryAPI.Extensions
{
    public static class ServiceConfiguration
    {
        public static void ApiConfiguration(this WebApplicationBuilder builder)
        {
            builder.Services.ConfigureSql(builder.Configuration);

            builder.Services.AddScoped<ILibraryRepositoryManager, LibraryRepositoryManager>();

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddScoped<IAuthorService, AuthorService>();

        }
    }
}
