using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "user",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    linkedin_url = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    university = table.Column<string>(type: "text", nullable: false),
                    skills = table.Column<string>(type: "text", nullable: false),
                    image_url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "experience",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    image_url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experience", x => x.id);
                    table.ForeignKey(
                        name: "FK_experience_user_user_id",
                        column: x => x.user_id,
                        principalSchema: "public",
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "user",
                columns: new[] { "id", "address", "birth_date", "description", "image_url", "linkedin_url", "name", "phone", "skills", "university" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), "Oslogata, 0278 Oslo", new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Erfaren webutvikler.", "https://example.com/alice.jpg", "https://linkedin.com/in/knutvikler", "Knut Vikler", "+47 123 45 678", "JavaScript;React;CSS;HTML", "Universitetet i Oslo" });

            migrationBuilder.InsertData(
                schema: "public",
                table: "experience",
                columns: new[] { "id", "description", "end_date", "image_url", "role", "start_date", "title", "type", "user_id" },
                values: new object[,]
                {
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Sommerjobb som utvikler hos Computas AS.", new DateTime(2011, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), "https://example.com/computas.jpg", "Utvikler", new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sommerjobb hos Computas AS", "work", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), "Fullførte bachelorgrad i informatikk ved Universitetet i Oslo.", new DateTime(2012, 5, 31, 0, 0, 0, 0, DateTimeKind.Utc), "https://example.com/uio_bachelor.jpg", "Student", new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bachelor i informatikk ved Universitetet i Oslo", "education", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "Fullførte mastergrad i informatikk ved Universitetet i Oslo.", new DateTime(2014, 5, 31, 0, 0, 0, 0, DateTimeKind.Utc), "https://example.com/uio_master.jpg", "Student", new DateTime(2012, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Master i informatikk ved Universitetet i Oslo", "education", new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_experience_user_id",
                schema: "public",
                table: "experience",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "experience",
                schema: "public");

            migrationBuilder.DropTable(
                name: "user",
                schema: "public");
        }
    }
}
