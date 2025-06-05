using backend.DTOs;
using backend.Services;

namespace backend.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        // GET /users
        app.MapGet("/users", async (ICvService cvService) =>
            {
                var users = await cvService.GetAllUsersAsync();
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
                var user = await svc.GetUserByIdAsync(id);
                if (user is null)
                    return Results.NotFound();

                var userDto = new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    BirthDate = user.BirthDate,
                    Address = user.Address,
                    Phone = user.Phone,
                    LinkedInUrl = user.LinkedInUrl,
                    Description = user.Description,
                    University = user.University,
                    Skills = user.Skills,
                    ImageUrl = user.ImageUrl
                };
                return Results.Ok(userDto);
            })
            .WithName("GetUserById")
            .WithTags("Users");
    }
}