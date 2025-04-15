using System.ComponentModel.DataAnnotations.Schema;

namespace CvBackendTest.Models;

[Table("cv_entries")]
public class CvEntry
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("start_date")]
    public DateTime StartDate { get; set; }

    [Column("end_date")]
    public DateTime? EndDate { get; set; }

    [Column("title")]
    public string Title { get; set; } = default!;

    [Column("description")]
    public string? Description { get; set; }
}