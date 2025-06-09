using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Data.Models
{
    [Table("user", Schema = "public")]
    public record User(
        [property: Column("id")] Guid Id,
        [property: Column("name")] string Name,
        [property: Column("birth_date")] DateTime BirthDate,
        [property: Column("address")] string Address,
        [property: Column("phone")] string Phone,
        [property: Column("linkedin_url")] string? LinkedInUrl,
        [property: Column("description")] string Description,
        [property: Column("university")] string University,
        [property: Column("skills")] string Skills,
        [property: Column("image_url")] string? ImageUrl
    )
    {
        public List<Experience> Experiences { get; init; } = [];
    }
}