using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationDotNetCoreGLSIA.Migrations
{
    /// <inheritdoc />
    public partial class TEstAPIFluent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropForeignKey(
                name: "FK_SousCategories_Categories_CategorieId",
                table: "SousCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categs",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categs",
                table: "Categs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SousCategories_Categs_CategorieId",
                table: "SousCategories",
                column: "CategorieId",
                principalTable: "Categs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SousCategories_Categs_CategorieId",
                table: "SousCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categs",
                table: "Categs");

            migrationBuilder.RenameTable(
                name: "Categs",
                newName: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldDefaultValue: "A");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SousCategories_Categories_CategorieId",
                table: "SousCategories",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
