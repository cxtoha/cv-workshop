using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedDataAndNewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "company",
                schema: "public",
                table: "experience",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                column: "company",
                value: "Computas");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "company", "image_url" },
                values: new object[] { "Universitetet i Oslo", "https://koro.no/content/uploads/2016/01/bilde-012uN1buKPdh-825x550.jpg" });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "company", "image_url" },
                values: new object[] { "Universitetet i Oslo", "https://koro.no/content/uploads/2016/01/bilde-012uN1buKPdh-825x550.jpg" });

            migrationBuilder.InsertData(
                schema: "public",
                table: "experience",
                columns: new[] { "id", "company", "description", "end_date", "image_url", "role", "start_date", "title", "type", "user_id" },
                values: new object[,]
                {
                    { new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"), null, "Hobbyprosjekt for å teste API-ene til Oslo Bysykkel i Android Studio", new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Utc), "https://tellusdmsmedia.newmindmedia.com/wsimgs/4_897936618.jpg[ProductImage][4D037D0DBBC22BD05D8BF069F3]", "Student", new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oslo bysykkel-sjekker", "Hobby project", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeeb"), "Teknologiporten ved NTNU", "Multidisiplinær bedriftskontakt", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc), "https://www.lifeinnorway.net/wp-content/uploads/2021/07/ntnu-trondheim-main-building.jpg", "Student", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Næringslivssjef i Teknologiporten", "Voluntary", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeef"), "Norges teknisk-naturvitenskapelige universitet", "Fullførte mastergrad i datateknologi ved NTNU Trondheim.", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc), "https://www.lifeinnorway.net/wp-content/uploads/2021/07/ntnu-trondheim-main-building.jpg", "Student", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Master i Datateknologi ved Norges teknisk-naturvitenskapelige universitet", "education", new Guid("11111111-1111-1111-1111-111111111111") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"));

            migrationBuilder.DeleteData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeeb"));

            migrationBuilder.DeleteData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeef"));

            migrationBuilder.DropColumn(
                name: "company",
                schema: "public",
                table: "experience");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                column: "image_url",
                value: "https://example.com/uio_bachelor.jpg");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                column: "image_url",
                value: "https://example.com/uio_master.jpg");
        }
    }
}
