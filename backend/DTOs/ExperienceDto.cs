namespace backend.DTOs;

public class ExperienceDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; } = null!;
    public string Role { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; } = null!;
    public string? ImageUrl { get; set; }
}