using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CvBackendTest.Models
{
    [Table("experience", Schema = "public")]
    public class Experience
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        public User? User { get; set; }

        [Column("title")]
        public string Title { get; set; } = default!;

        [Column("role")]
        public string Role { get; set; } = default!;

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("description")]
        public string Description { get; set; } = default!;

        [Column("image_url")]
        public string? ImageUrl { get; set; }
    }
}
