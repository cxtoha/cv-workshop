using CvBackendTest.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Load connection string from secrets or appsettings
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Load the frontend API key from secrets
var frontendApiKey = builder.Configuration["AppSettings:FrontendApiKey"];

// Add EF Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:5173",   // Vite dev server
                "https://your-frontend.com" // placeholder for production
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


var app = builder.Build();

app.UseCors("AllowFrontend");


// 🔐 Middleware to check API key on every request
app.Use(async (context, next) =>
{
    // Let preflight requests through
    if (context.Request.Method == HttpMethods.Options)
    {
        context.Response.StatusCode = StatusCodes.Status204NoContent;
        return;
    }

    var expectedKey = frontendApiKey;
    var actualKey = context.Request.Headers["X-Frontend-Api-Key"].FirstOrDefault();

    if (string.IsNullOrWhiteSpace(actualKey) || actualKey != expectedKey)
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.Response.WriteAsync("Unauthorized");
        return;
    }

    await next();
});


// Endpoint: GET /cv-entries
app.MapGet("/cv-entries", async (AppDbContext db) =>
{
    var entries = await db.CvEntries
        .OrderByDescending(e => e.StartDate)
        .ToListAsync();
    return Results.Ok(entries);
});

app.Run();