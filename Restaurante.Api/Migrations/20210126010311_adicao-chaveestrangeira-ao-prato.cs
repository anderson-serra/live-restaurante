using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class adicaochaveestrangeiraaoprato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPratoId",
                table: "Prato",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prato_TipoPratoId",
                table: "Prato",
                column: "TipoPratoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoPrato",
                table: "Prato",
                column: "TipoPratoId",
                principalTable: "TipoPrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoPrato",
                table: "Prato");

            migrationBuilder.DropIndex(
                name: "IX_Prato_TipoPratoId",
                table: "Prato");

            migrationBuilder.DropColumn(
                name: "TipoPratoId",
                table: "Prato");
        }
    }
}
