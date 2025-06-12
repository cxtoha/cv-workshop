using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UppercaseSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "description", "title" },
                values: new object[] { "Fullførte bachelorgrad i Informatikk ved Universitetet i Oslo.", "Bachelor i Informatikk ved UiO" });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"),
                column: "title",
                value: "Oslo Bysykkel - Android app");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "description", "title" },
                values: new object[] { "Fullførte mastergrad i Informatikk ved Universitetet i Oslo.", "Master i Informatikk ved UiO" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "public",
                table: "experience",
                keyColumn: "id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "description", "title" },
                values: new object[] { "Fullførte bachelorgrad i informatikk ved Universitetet i Oslo.", "Bachelor i informatikk ved UiO" });

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
                columns: new[] { "description", "title" },
                values: new object[] { "Fullførte mastergrad i informatikk ved Universitetet i Oslo.", "Master i informatikk ved UiO" });
        }
    }
}
