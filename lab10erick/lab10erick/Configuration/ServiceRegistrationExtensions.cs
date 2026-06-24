using lab10erick.Infrastructure.Configuration;
namespace lab10erick.Configuration;

public static class ServiceRegistrationExtensions
{
    public static IServiceCollection AddAppServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddControllers();

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen();

        services.AddInfrastructureServices(configuration);

        return services;
    }
}