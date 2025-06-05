using backend.DTOs;
using backend.Services;

namespace backend.Endpoints;

public static class ExperienceEndpoints
{
    public static void MapExperienceEndpoints(this WebApplication app)
    {
        // GET /experiences
        app.MapGet("/experiences", async (ICvService svc) =>
            {
                var exps = await svc.GetAllExperiencesAsync();
                var experienceDtos = exps
                    .Select(e => new ExperienceDto
                    {
                        Id = e.Id,
                        UserId = e.UserId,
                        Title = e.Title,
                        Role = e.Role,
                        StartDate = e.StartDate,
                        EndDate = e.EndDate,
                        Description = e.Description,
                        ImageUrl = e.ImageUrl
                    })
                    .ToList();

                return Results.Ok(experienceDtos);
            })
            .WithName("GetAllExperiences")
            .WithTags("Experiences");

        // GET /experiences/{id}
        app.MapGet("/experiences/{id:guid}", async (Guid id, ICvService svc) =>
            {
                var e = await svc.GetExperienceByIdAsync(id);
                if (e is null)
                    return Results.NotFound();

                var dto = new ExperienceDto
                {
                    Id = e.Id,
                    UserId = e.UserId,
                    Title = e.Title,
                    Role = e.Role,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    Description = e.Description,
                    ImageUrl = e.ImageUrl
                };
                return Results.Ok(dto);
            })
            .WithName("GetExperienceById")
            .WithTags("Experiences");
    }
}