using First.Cojali.Api.Contracts.Configuration;
using First.Cojali.Api.IoC.Mappings;
using First.Cojali.Application.Interfaces;
using First.Cojali.Application.Services;
using First.Cojali.Infrastructure.Adapters;
using First.Cojali.Infrastructure.Utilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace First.Cojali.Api.IoC;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomDependencies(this IServiceCollection services)
    {
        // Register Services
        services.AddScoped<IUserService, UserService>();

        // Register Repositories
        services.AddScoped<IUserRepository>(provider =>
        {
            var configuration = provider.GetRequiredService<IOptions<AppSettings>>().Value;
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Relative path to navigate from the executing directory to the Infrastructure directory
            var absolutePath = PathResolver.ResolveAndValidatePath(
                currentDirectory,
                configuration.UserJsonFilePath,
                "The User JSON file was not found."
            );

            return new UserRepository(absolutePath);
        });

        // Register AutoMapper profiles
        services.AddAutoMapper(cfg =>
        {
            cfg.AddProfile<ApiMappingProfile>();
            cfg.AddProfile<ApplicationMappingProfile>();
        });

        return services;
    }
}
