using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Data.Models
{
    [Table("user", Schema = "public")]
    public class User
    {
        [Column("id")]
        public Guid Id { get; init; }

        [Column("name")]
        public string Name { get; init; } = null!;

        [Column("birth_date")]
        public DateTime BirthDate { get; init; }

        [Column("address")]
        public string Address { get; init; } = null!;

        [Column("phone")]
        public string Phone { get; init; } = null!;

        [Column("linkedin_url")]
        public string? LinkedInUrl { get; init; }

        [Column("description")]
        public string Description { get; init; } = null!;

        [Column("university")]
        public string University { get; init; } = null!;

        [Column("skills")]
        public string Skills { get; init; } = null!;

        [Column("image_url")]
        public string? ImageUrl { get; init; }

        public List<Experience> Experiences { get; init; } = [];
    }
}
