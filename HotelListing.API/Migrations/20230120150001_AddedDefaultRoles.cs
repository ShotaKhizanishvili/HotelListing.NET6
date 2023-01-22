using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e30d7ca-057a-47c2-93b5-c32ed861fb5f", "68ea6a01-b21b-4c86-8049-0c0469a83d5f", "User", "User" },
                    { "e40180a2-a4ac-4da5-81b9-737509d1bcfc", "4628a0eb-8235-44d4-8326-0daf60605502", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e30d7ca-057a-47c2-93b5-c32ed861fb5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e40180a2-a4ac-4da5-81b9-737509d1bcfc");
        }
    }
}
