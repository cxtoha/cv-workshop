using backend.DTOs;
using backend.Services;

namespace backend.Endpoints;

public static class ExperienceEndpoints
{
    public static void MapExperienceEndpoints(this WebApplication app)
    {
        // GET /experiences
        app.MapGet("/experiences", async (ICvService cvService) =>
            {
                var experiences = await cvService.GetAllExperiencesAsync();
                var experienceDtos = experiences
                    .Select(e => new ExperienceDto
                    {
                        Id = e.Id,
                        UserId = e.UserId,
                        Title = e.Title,
                        Role = e.Role,
                        Type = e.Type,
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
        app.MapGet("/experiences/{id:guid}", async (Guid id, ICvService cvService) =>
            {
                var experience = await cvService.GetExperienceByIdAsync(id);
                if (experience is null)
                    return Results.NotFound();

                var experienceDto = new ExperienceDto
                {
                    Id = experience.Id,
                    UserId = experience.UserId,
                    Title = experience.Title,
                    Role = experience.Role,
                    Type = experience.Type,
                    StartDate = experience.StartDate,
                    EndDate = experience.EndDate,
                    Description = experience.Description,
                    ImageUrl = experience.ImageUrl
                };
                return Results.Ok(experienceDto);
            })
            .WithName("GetExperienceById")
            .WithTags("Experiences");

        // GET /experiences/type/{type}
        app.MapGet("/experiences/type/{type}", async (string Type, ICvService cvService) =>
        {
            var experiences = await cvService.GetExperiencesByTypeAsync(Type);
            var experienceDtos = experiences
                .Select(e => new ExperienceDto
                {
                    Id = e.Id,
                    UserId = e.UserId,
                    Title = e.Title,
                    Role = e.Role,
                    Type = e.Type,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    Description = e.Description,
                    ImageUrl = e.ImageUrl
                })
                .ToList();

            return Results.Ok(experienceDtos);
        })
        .WithName("GetExperiencesByType")
        .WithTags("Experiences");
    }
}