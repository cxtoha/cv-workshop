using backend.Data;
using backend.Endpoints;
using backend.Extensions;
using backend.Middleware;
using backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Konfigurer Entity Framework Core og DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// Registrer CV-service
builder.Services.AddScoped<ICvService, CvService>();

// Konfigurer CORS
builder.Services.AddCorsServices(builder.Configuration);

// Konfigurer Swagger/OpenAPI
builder.Services.AddSwaggerServices();

var app = builder.Build();

// Global Exception handling
app.UseMiddleware<ExceptionMiddleware>();

// Aktiver Swagger UI
app.UseSwaggerWithUi();

// Aktiver CORS
app.UseCorsPolicy();

// Middleware for API-nøkkelbeskyttelse
// app.UseMiddleware<ApiKeyMiddleware>();

// Koble til GET-endepunkter
app.MapUserEndpoints();
app.MapExperienceEndpoints();

// Kjør applikasjonen
app.Run();