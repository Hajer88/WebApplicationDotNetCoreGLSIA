using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationDotNetCoreGLSIA.Migrations
{
    /// <inheritdoc />
    public partial class TestApiFluent2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SousCategories",
                newName: "SubCatName");

            migrationBuilder.AlterColumn<string>(
                name: "SubCatName",
                table: "SousCategories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categs",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ca72b856-c29b-4df4-89e3-14b6586d512a"), "test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categs",
                keyColumn: "Id",
                keyValue: new Guid("ca72b856-c29b-4df4-89e3-14b6586d512a"));

            migrationBuilder.RenameColumn(
                name: "SubCatName",
                table: "SousCategories",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SousCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }
    }
}
