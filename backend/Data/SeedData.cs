using backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public static class SeedData
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Knut Vikler",
                    BirthDate = new DateTime(1990, 06, 15, 0, 0, 0, DateTimeKind.Utc),
                    Address = "Oslogata, 0278 Oslo",
                    Phone = "+47 123 45 678",
                    LinkedInUrl = "https://linkedin.com/in/knutvikler",
                    Description = "Erfaren webutvikler.",
                    University = "Universitetet i Oslo",
                    Skills = "JavaScript;React;CSS;HTML",
                    ImageUrl = "https://example.com/alice.jpg"
                }
            );
        }

        public static void SeedExperiences(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Title = "Sommerjobb hos Computas AS",
                    Role = "Utvikler",
                    Type = "work",
                    StartDate = new DateTime(2011, 06, 01, 0, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2011, 08, 31, 0, 0, 0, DateTimeKind.Utc),
                    Description = "Sommerjobb som utvikler hos Computas AS.",
                    ImageUrl = "https://example.com/computas.jpg"
                },
                new Experience
                {
                    Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                    UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Title = "Bachelor i informatikk ved Universitetet i Oslo",
                    Role = "Student",
                    Type = "education",
                    StartDate = new DateTime(2008, 08, 01, 0, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2012, 05, 31, 0, 0, 0, DateTimeKind.Utc),
                    Description = "Fullførte bachelorgrad i informatikk ved Universitetet i Oslo.",
                    ImageUrl = "https://example.com/uio_bachelor.jpg"
                },
                new Experience
                {
                    Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                    UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Title = "Master i informatikk ved Universitetet i Oslo",
                    Role = "Student",
                    Type = "education",
                    StartDate = new DateTime(2012, 08, 01, 0, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2014, 05, 31, 0, 0, 0, DateTimeKind.Utc),
                    Description = "Fullførte mastergrad i informatikk ved Universitetet i Oslo.",
                    ImageUrl = "https://example.com/uio_master.jpg"
                }
            );
        }
    }
}
