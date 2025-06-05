namespace backend.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? LinkedInUrl { get; set; }
    public string Description { get; set; } = null!;
    public string University { get; set; } = null!;
    public string Skills { get; set; } = null!;
    public string? ImageUrl { get; set; }
}