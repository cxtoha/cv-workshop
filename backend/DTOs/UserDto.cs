namespace backend.DTOs;

public record UserDto(
    Guid Id,
    string Name,
    DateTime BirthDate,
    string Address,
    string Phone,
    string? LinkedInUrl,
    string Description,
    string University,
    string Skills,
    string? ImageUrl
);
