using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationDotNetCoreGLSIA.Migrations
{
    /// <inheritdoc />
    public partial class AddProduitManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProduitssCategorie",
                columns: table => new
                {
                    produitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sscategsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitssCategorie", x => new { x.produitsId, x.sscategsId });
                    table.ForeignKey(
                        name: "FK_ProduitssCategorie_SousCategories_sscategsId",
                        column: x => x.sscategsId,
                        principalTable: "SousCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProduitssCategorie_produits_produitsId",
                        column: x => x.produitsId,
                        principalTable: "produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categs",
                keyColumn: "Id",
                keyValue: new Guid("ca72b856-c29b-4df4-89e3-14b6586d512a"),
                column: "Name",
                value: "test");

            migrationBuilder.CreateIndex(
                name: "IX_ProduitssCategorie_sscategsId",
                table: "ProduitssCategorie",
                column: "sscategsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProduitssCategorie");

            migrationBuilder.DropTable(
                name: "produits");

            migrationBuilder.UpdateData(
                table: "Categs",
                keyColumn: "Id",
                keyValue: new Guid("ca72b856-c29b-4df4-89e3-14b6586d512a"),
                column: "Name",
                value: "Categorie Test FluentAPI");
        }
    }
}
