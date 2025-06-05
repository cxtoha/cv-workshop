namespace backend.Middleware;

public class ApiKeyMiddleware(RequestDelegate next, IConfiguration config)
{
    private readonly string _expectedKey = config["AppSettings:FrontendApiKey"]
                                           ?? throw new InvalidOperationException("FrontendApiKey not configured.");

    public async Task InvokeAsync(HttpContext context)
    {
        // Slipp gjennom preflight OPTIONS
        if (context.Request.Method == HttpMethods.Options)
        {
            context.Response.StatusCode = StatusCodes.Status204NoContent;
            return;
        }

        var actualKey = context.Request.Headers["X-Frontend-Api-Key"].FirstOrDefault();
        if (string.IsNullOrWhiteSpace(actualKey) || actualKey != _expectedKey)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Unauthorized");
            return;
        }

        await next(context);
    }
}