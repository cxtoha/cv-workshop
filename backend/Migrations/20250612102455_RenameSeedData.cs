using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class RenameSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "company", "title" },
                values: new object[] { "Computas AS", "Sommerjobb hos Computas" });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                column: "title",
                value: "Bachelor i informatikk ved UiO");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"),
                column: "title",
                value: "Oslo bysykkelsjekker");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                column: "title",
                value: "Master i informatikk ved UiO");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeef"),
                column: "title",
                value: "Master i Datateknologi ved NTNU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "company", "title" },
                values: new object[] { "Computas", "Sommerjobb hos Computas AS" });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                column: "title",
                value: "Bachelor i informatikk ved Universitetet i Oslo");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"),
                column: "title",
                value: "Oslo bysykkel-sjekker");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                column: "title",
                value: "Master i informatikk ved Universitetet i Oslo");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeef"),
                column: "title",
                value: "Master i Datateknologi ved Norges teknisk-naturvitenskapelige universitet");
        }
    }
}
