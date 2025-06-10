using backend.Data.Mappers;
using backend.Services;

namespace backend.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        // GET /users
        app.MapGet(
                "/users",
                async (ICvService cvService) =>
                {
                    var users = await cvService.GetAllUsersAsync();
                    var userDtos = users.Select(u => u.ToDto()).ToList();

                    return Results.Ok(userDtos);
                }
            )
            .WithName("GetAllUsers")
            .WithTags("Users");

        // GET /users/{id}
        app.MapGet(
                "/users/{id:guid}",
                async (Guid id, ICvService svc) =>
                {
                    var user = await svc.GetUserByIdAsync(id);
                    if (user is null)
                        return Results.NotFound();

                    var userDto = user.ToDto();
                    return Results.Ok(userDto);
                }
            )
            .WithName("GetUserById")
            .WithTags("Users");
    }
}
