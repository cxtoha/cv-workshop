using Microsoft.OpenApi.Models;

namespace backend.Extensions;

public static class SwaggerExtensions
{
    public static void AddSwaggerServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc(
                "v1",
                new OpenApiInfo { Title = "CV-API (Minimal)", Version = "v1" }
            );
        });
    }

    public static void UseSwaggerWithUi(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "CV-API V1");
            options.EnableDeepLinking();
            options.DisplayOperationId();
            options.RoutePrefix = "";
        });
    }
}
