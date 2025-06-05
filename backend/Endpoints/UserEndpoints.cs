using backend.DTOs;
using backend.Services;

namespace backend.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        // GET /users
        app.MapGet("/users", async (ICvService svc) =>
            {
                var users = await svc.GetAllUsersAsync();
                var userDtos = users
                    .Select(u => new UserDto
                    {
                        Id = u.Id,
                        Name = u.Name,
                        BirthDate = u.BirthDate,
                        Address = u.Address,
                        Phone = u.Phone,
                        LinkedInUrl = u.LinkedInUrl,
                        Description = u.Description,
                        University = u.University,
                        Skills = u.Skills,
                        ImageUrl = u.ImageUrl
                    })
                    .ToList();

                return Results.Ok(userDtos);
            })
            .WithName("GetAllUsers")
            .WithTags("Users");

        // GET /users/{id}
        app.MapGet("/users/{id:guid}", async (Guid id, ICvService svc) =>
            {
                var u = await svc.GetUserByIdAsync(id);
                if (u is null)
                    return Results.NotFound();

                var dto = new UserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    BirthDate = u.BirthDate,
                    Address = u.Address,
                    Phone = u.Phone,
                    LinkedInUrl = u.LinkedInUrl,
                    Description = u.Description,
                    University = u.University,
                    Skills = u.Skills,
                    ImageUrl = u.ImageUrl
                };
                return Results.Ok(dto);
            })
            .WithName("GetUserById")
            .WithTags("Users");
    }
}