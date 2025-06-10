using backend.Data.Models;
using backend.DTOs;

namespace backend.Data.Mappers;

public static class UserMapper
{
    public static UserDto ToDto(this User user) =>
        new(
            Id: user.Id,
            Name: user.Name,
            BirthDate: user.BirthDate,
            Address: user.Address,
            Phone: user.Phone,
            LinkedInUrl: user.LinkedInUrl,
            Description: user.Description,
            University: user.University,
            Skills: user.Skills,
            ImageUrl: user.ImageUrl
        );
}
