using CvBackendTest.Data;
using Microsoft.EntityFrameworkCore;

// Opprette builder
var builder = WebApplication.CreateBuilder(args);

// Henter tilkoblingsstreng til databasen fra secrets eller appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Henter API-nøkkel som frontend må sende med hver request
var frontendApiKey = builder.Configuration["AppSettings:FrontendApiKey"];

// Registrerer EF Core og konfigurerer PostgreSQL med tilkoblingsstrengen
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// Konfigurerer CORS slik at frontend får lov til å snakke med backend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:5173",   		// Vite dev-server (lokal utvikling)
                "https://your-frontend.com" 	// Produksjon (erstatt senere)
            )
            .AllowAnyHeader() // Tillat alle HTTP-headere
            .AllowAnyMethod(); // Tillat alle HTTP-metoder (GET, POST, osv.)
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure Swagger UI with custom options
app.UseSwaggerUI(c =>
{
    // Customize the UI (optional)
    c.EnableDeepLinking();
    c.DisplayOperationId();
});

app.UseSwagger();

// Aktiverer CORS-policyen som ble konfigurert over
app.UseCors("AllowFrontend");

// Middleware for å beskytte API-et med API-nøkkel
app.Use(async (context, next) =>
{
    // Slipper gjennom preflight-requests (OPTIONS) uten autentisering
    if (context.Request.Method == HttpMethods.Options)
    {
        context.Response.StatusCode = StatusCodes.Status204NoContent;
        return;
    }

    var expectedKey = frontendApiKey;
    var actualKey = context.Request.Headers["X-Frontend-Api-Key"].FirstOrDefault();

    // Returner 401 hvis nøkkel mangler eller er feil
    if (string.IsNullOrWhiteSpace(actualKey) || actualKey != expectedKey)
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.Response.WriteAsync("Unauthorized");
        return;
    }

    // Nøkkel er riktig -> gå videre til neste middleware/route
    await next();
});

// Definer GET-endepunkter
app.MapGet("/users", async (AppDbContext db) =>
{
    var users = await db.Users
        .OrderBy(u => u.Name)
        .ToListAsync();
    return Results.Ok(users);
});

app.MapGet("/experiences", async (AppDbContext db) =>
{
    var exps = await db.Experiences
        .OrderByDescending(e => e.StartDate)
        .ToListAsync();
    return Results.Ok(exps);
});

// Starter webserveren
app.Run();
