using System.Net;
using System.Text.Json;

namespace backend.Middleware;

public class ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unhandled exception occurred.");
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";
            var payload = JsonSerializer.Serialize(new { Error = "An unexpected error occurred." });
            await context.Response.WriteAsync(payload);
        }
    }
}