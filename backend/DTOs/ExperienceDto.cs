namespace backend.DTOs;

public record ExperienceDto(
    Guid Id,
    Guid UserId,
    string Title,
    string Role,
    string Type,
    DateTime StartDate,
    DateTime? EndDate,
    string Description,
    string? ImageUrl,
    string? Company
);
