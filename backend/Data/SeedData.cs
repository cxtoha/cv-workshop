using backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public static class SeedData
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasData(
                    new User(
                        Id: Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        Name: "Knut Vikler",
                        BirthDate: new DateTime(1990, 06, 15, 0, 0, 0, DateTimeKind.Utc),
                        Address: "Oslogata, 0278 Oslo",
                        Phone: "+47 123 45 678",
                        LinkedInUrl: "https://linkedin.com/in/knutvikler",
                        Description: "Erfaren webutvikler.",
                        University: "Universitetet i Oslo",
                        Skills: "JavaScript;React;CSS;HTML;TypeScript",
                        ImageUrl: "https://example.com/alice.jpg"
                    ),
                    new User(
                        Id: Guid.Parse("11111111-1111-1111-1111-111111111112"),
                        Name: "Comp Utas",
                        BirthDate: new DateTime(1990, 06, 15, 0, 0, 0, DateTimeKind.Utc),
                        Address: "Oslogata, 0278 Oslo",
                        Phone: "+47 123 45 678",
                        LinkedInUrl: "https://linkedin.com/in/computas",
                        Description: "Seig backendutvikler",
                        University: "Universitetet på Svalbard",
                        Skills: "Go;TypeScript;Kotlin;Postgres",
                        ImageUrl: "https://example.com/alice.jpg"
                    ),
                    new User(
                        Id: Guid.Parse("11111111-1111-1111-1111-111111111113"),
                        Name: "Kari Kanari",
                        BirthDate: new DateTime(1990, 06, 15, 0, 0, 0, DateTimeKind.Utc),
                        Address: "Oslogata, 0278 Oslo",
                        Phone: "+47 123 45 678",
                        LinkedInUrl: "https://linkedin.com/in/lsk",
                        Description: "Senior fullstackutvikler.",
                        University: "NTNU",
                        Skills: "JavaScript;React;Kotlin;CSS;HTML;TypeScript;Python",
                        ImageUrl: "https://example.com/alice.jpg"
                    )
                );
        }

        public static void SeedExperiences(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Experience>()
                .HasData(
                    new Experience(
                        Id: Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                        UserId: Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        Title: "Sommerjobb hos Computas",
                        Role: "Utvikler",
                        Type: "work",
                        StartDate: new DateTime(2011, 06, 01, 0, 0, 0, DateTimeKind.Utc),
                        EndDate: new DateTime(2011, 08, 31, 0, 0, 0, DateTimeKind.Utc),
                        Description: "Sommerjobb som utvikler hos Computas AS.",
                        ImageUrl: "https://www.proff.no/imagine/cache/7029839_fullsize.jpg",
                        Company: "Computas AS"
                    ),
                    new Experience(
                        Id: Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                        UserId: Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        Title: "Bachelor i informatikk ved UiO",
                        Role: "Student",
                        Type: "education",
                        StartDate: new DateTime(2008, 08, 01, 0, 0, 0, DateTimeKind.Utc),
                        EndDate: new DateTime(2012, 05, 31, 0, 0, 0, DateTimeKind.Utc),
                        Description: "Fullførte bachelorgrad i informatikk ved Universitetet i Oslo.",
                        ImageUrl: "https://koro.no/content/uploads/2016/01/bilde-012uN1buKPdh-825x550.jpg",
                        Company: "Universitetet i Oslo"
                    ),
                    new Experience(
                        Id: Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                        UserId: Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        Title: "Master i informatikk ved UiO",
                        Role: "Student",
                        Type: "education",
                        StartDate: new DateTime(2012, 08, 01, 0, 0, 0, DateTimeKind.Utc),
                        EndDate: new DateTime(2014, 05, 31, 0, 0, 0, DateTimeKind.Utc),
                        Description: "Fullførte mastergrad i informatikk ved Universitetet i Oslo.",
                        ImageUrl: "https://koro.no/content/uploads/2016/01/bilde-012uN1buKPdh-825x550.jpg",
                        Company: "Universitetet i Oslo"
                    ),
                    new Experience(
                        Id: Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeef"),
                        UserId: Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        Title: "Master i Datateknologi ved NTNU",
                        Role: "Student",
                        Type: "education",
                        StartDate: new DateTime(2019, 08, 01, 0, 0, 0, DateTimeKind.Utc),
                        EndDate: new DateTime(2024, 06, 30, 0, 0, 0, DateTimeKind.Utc),
                        Description: "Fullførte mastergrad i datateknologi ved NTNU Trondheim.",
                        ImageUrl: "https://www.lifeinnorway.net/wp-content/uploads/2021/07/ntnu-trondheim-main-building.jpg",
                        Company: "Norges teknisk-naturvitenskapelige universitet"
                    ),
                    new Experience(
                        Id: Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeeb"),
                        UserId: Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        Title: "Næringslivssjef i Teknologiporten",
                        Role: "Student",
                        Type: "Voluntary",
                        StartDate: new DateTime(2019, 08, 01, 0, 0, 0, DateTimeKind.Utc),
                        EndDate: new DateTime(2022, 06, 30, 0, 0, 0, DateTimeKind.Utc),
                        Description: "Multidisiplinær bedriftskontakt",
                        ImageUrl: "https://www.lifeinnorway.net/wp-content/uploads/2021/07/ntnu-trondheim-main-building.jpg",
                        Company: "Teknologiporten ved NTNU"
                    ),
                    new Experience(
                        Id: Guid.Parse("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"),
                        UserId: Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        Title: "Oslo bysykkelsjekker",
                        Role: "Student",
                        Type: "Hobby project",
                        StartDate: new DateTime(2022, 08, 01, 0, 0, 0, DateTimeKind.Utc),
                        EndDate: new DateTime(2022, 10, 28, 0, 0, 0, DateTimeKind.Utc),
                        Description: "Hobbyprosjekt for å teste API-ene til Oslo Bysykkel i Android Studio",
                        ImageUrl: "https://tellusdmsmedia.newmindmedia.com/wsimgs/4_897936618.jpg[ProductImage][4D037D0DBBC22BD05D8BF069F3]",
                        Company: null
                    )
                );
        }
    }
}
