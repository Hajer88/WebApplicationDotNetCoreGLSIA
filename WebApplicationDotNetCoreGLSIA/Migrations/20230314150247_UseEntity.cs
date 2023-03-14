using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationDotNetCoreGLSIA.Migrations
{
    /// <inheritdoc />
    public partial class UseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduitssCategorie_SousCategories_sscategsId",
                table: "ProduitssCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduitssCategorie_produits_produitsId",
                table: "ProduitssCategorie");

            migrationBuilder.RenameColumn(
                name: "sscategsId",
                table: "ProduitssCategorie",
                newName: "ssCategorieId");

            migrationBuilder.RenameColumn(
                name: "produitsId",
                table: "ProduitssCategorie",
                newName: "ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_ProduitssCategorie_sscategsId",
                table: "ProduitssCategorie",
                newName: "IX_ProduitssCategorie_ssCategorieId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAjout",
                table: "ProduitssCategorie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitssCategorie_SousCategories_ssCategorieId",
                table: "ProduitssCategorie",
                column: "ssCategorieId",
                principalTable: "SousCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitssCategorie_produits_ProduitId",
                table: "ProduitssCategorie",
                column: "ProduitId",
                principalTable: "produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduitssCategorie_SousCategories_ssCategorieId",
                table: "ProduitssCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduitssCategorie_produits_ProduitId",
                table: "ProduitssCategorie");

            migrationBuilder.DropColumn(
                name: "DateAjout",
                table: "ProduitssCategorie");

            migrationBuilder.RenameColumn(
                name: "ssCategorieId",
                table: "ProduitssCategorie",
                newName: "sscategsId");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "ProduitssCategorie",
                newName: "produitsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProduitssCategorie_ssCategorieId",
                table: "ProduitssCategorie",
                newName: "IX_ProduitssCategorie_sscategsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitssCategorie_SousCategories_sscategsId",
                table: "ProduitssCategorie",
                column: "sscategsId",
                principalTable: "SousCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitssCategorie_produits_produitsId",
                table: "ProduitssCategorie",
                column: "produitsId",
                principalTable: "produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
