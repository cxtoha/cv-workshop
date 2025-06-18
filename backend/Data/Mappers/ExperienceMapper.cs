using backend.Data.Models;
using backend.DTOs;

namespace backend.Data.Mappers;

public static class ExperienceMapper
{
    public static ExperienceDto ToDto(this Experience ex) =>
        new(
            Id: ex.Id,
            UserId: ex.UserId,
            Title: ex.Title,
            Role: ex.Role,
            Type: ex.Type,
            StartDate: ex.StartDate,
            EndDate: ex.EndDate,
            Description: ex.Description,
            ImageUrl: ex.ImageUrl,
            Company: ex.Company
        );
}
