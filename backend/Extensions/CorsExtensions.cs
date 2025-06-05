namespace backend.Extensions;

public static class CorsExtensions
{
    private const string AllowFrontendPolicy = "AllowFrontend";

    public static void AddCorsServices(this IServiceCollection services, IConfiguration config)
    {
        var origins = config.GetSection("AllowedCorsOrigins").Get<string[]>()
            ?? [];

        services.AddCors(options =>
        {
            options.AddPolicy(AllowFrontendPolicy, builder =>
            {
                builder
                    .WithOrigins(origins)
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }

    public static void UseCorsPolicy(this WebApplication app)
    {
        app.UseCors(AllowFrontendPolicy);
    }
}