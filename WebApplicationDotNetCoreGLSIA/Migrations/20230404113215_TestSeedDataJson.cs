using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationDotNetCoreGLSIA.Migrations
{
    /// <inheritdoc />
    public partial class TestSeedDataJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categs",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d3d3a0db-f8c0-4cf9-a643-ed85feea7f3a"), "TestFromJsonFile" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categs",
                keyColumn: "Id",
                keyValue: new Guid("d3d3a0db-f8c0-4cf9-a643-ed85feea7f3a"));
        }
    }
}
