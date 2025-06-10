using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "public",
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "skills",
                value: "JavaScript;React;CSS;HTML;TypeScript");

            migrationBuilder.InsertData(
                schema: "public",
                table: "user",
                columns: new[] { "id", "address", "birth_date", "description", "image_url", "linkedin_url", "name", "phone", "skills", "university" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111112"), "Oslogata, 0278 Oslo", new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Seig backendutvikler", "https://example.com/alice.jpg", "https://linkedin.com/in/computas", "Comp Utas", "+47 123 45 678", "Go;TypeScript;Kotlin;Postgres", "Universitetet på Svalbard" },
                    { new Guid("11111111-1111-1111-1111-111111111113"), "Oslogata, 0278 Oslo", new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Senior fullstackutvikler.", "https://example.com/alice.jpg", "https://linkedin.com/in/lsk", "Kari Kanari", "+47 123 45 678", "JavaScript;React;Kotlin;CSS;HTML;TypeScript;Python", "NTNU" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "public",
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"));

            migrationBuilder.DeleteData(
                schema: "public",
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "skills",
                value: "JavaScript;React;CSS;HTML");
        }
    }
}
