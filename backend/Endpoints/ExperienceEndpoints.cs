﻿using backend.Data.Mappers;
using backend.Services;

namespace backend.Endpoints;

public static class ExperienceEndpoints
{
    public static void MapExperienceEndpoints(this WebApplication app)
    {
        // GET /experiences
        app.MapGet(
                "/experiences",
                async (ICvService cvService) =>
                {
                    var experiences = await cvService.GetAllExperiencesAsync();
                    var eDtos = experiences.Select(e => e.ToDto()).ToList();

                    return Results.Ok(eDtos);
                }
            )
            .WithName("GetAllExperiences")
            .WithTags("Experiences");

        // GET /experiences/{id}
        app.MapGet(
                "/experiences/{id:guid}",
                async (Guid id, ICvService cvService) =>
                {
                    var experience = await cvService.GetExperienceByIdAsync(id);
                    if (experience is null) return Results.NotFound();
                    var eDto = experience.ToDto();

                    return Results.Ok(eDto);
                }
            )
            .WithName("GetExperienceById")
            .WithTags("Experiences");

        // GET /experiences/type/{type}
        app.MapGet(
                "/experiences/type/{type}",
                async (string type, ICvService cvService) =>
                {
                    var experiences = await cvService.GetExperiencesByTypeAsync(type);
                    var eDtos = experiences.Select(e => e.ToDto()).ToList();

                    return Results.Ok(eDtos);
                }
            )
            .WithName("GetExperiencesByType")
            .WithTags("Experiences");
    }
}
