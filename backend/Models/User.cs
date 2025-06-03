using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CvBackendTest.Models
{
    [Table("user", Schema = "public")]
    public class User
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = default!;

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("address")]
        public string Address { get; set; } = default!;

        [Column("phone")]
        public string Phone { get; set; } = default!;

        [Column("linkedin_url")]
        public string? LinkedInUrl { get; set; }

        [Column("description")]
        public string Description { get; set; } = default!;

        [Column("university")]
        public string University { get; set; } = default!;

        [Column("skills")]
        public string Skills { get; set; } = default!;

        [Column("image_url")]
        public string? ImageUrl { get; set; }

        // Navigation property: one user can have many experiences
        public List<Experience> Experiences { get; set; } = new();
    }
}
