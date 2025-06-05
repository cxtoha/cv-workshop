using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Data.Models
{
    [Table("experience", Schema = "public")]
    public class Experience
    {
        [Column("id")]
        public Guid Id { get; init; }

        [Column("user_id")]
        public Guid UserId { get; init; }

        public User? User { get; init; }

        [Column("title")]
        public string Title { get; init; } = null!;

        [Column("role")]
        public string Role { get; init; } = null!;

        [Column("start_date")]
        public DateTime StartDate { get; init; }

        [Column("end_date")]
        public DateTime? EndDate { get; init; }

        [Column("description")]
        public string Description { get; init; } = null!;

        [Column("image_url")]
        public string? ImageUrl { get; init; }
    }
}
