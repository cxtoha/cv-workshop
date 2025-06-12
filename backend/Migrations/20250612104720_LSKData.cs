using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class LSKData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"),
                column: "type",
                value: "hobbyProject");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeeb"),
                column: "type",
                value: "voluntary");

            migrationBuilder.InsertData(
                schema: "public",
                table: "experience",
                columns: new[] { "id", "company", "description", "end_date", "image_url", "role", "start_date", "title", "type", "user_id" },
                values: new object[] { new Guid("eeeceeee-eeee-eeee-eeee-eeeeeeeeeeea"), "Lillestrøm Sportsklubb", "Assistenttrener for Lillestrøm gutter 14. Treninger to dager i uka.", new DateTime(2017, 5, 28, 0, 0, 0, 0, DateTimeKind.Utc), "https://g.acdn.no/obscura/API/dynamic/r1/ece5/tr_2000_2000_s_f/1738746244000/rome/2025/2/5/10/lsk-bod_glimt-19.jpg?chk=17E80E", "Coach", new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Assistenttrener LSK G14", "coach", new Guid("11111111-1111-1111-1111-111111111111") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeceeee-eeee-eeee-eeee-eeeeeeeeeeea"));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"),
                column: "type",
                value: "Hobby project");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeeb"),
                column: "type",
                value: "Voluntary");
        }
    }
}
