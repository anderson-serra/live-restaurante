using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class migrationteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Refeicoes",
                table: "Refeicoes");

            migrationBuilder.RenameTable(
                name: "Refeicoes",
                newName: "Refeicao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refeicao",
                table: "Refeicao",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Refeicao",
                table: "Refeicao");

            migrationBuilder.RenameTable(
                name: "Refeicao",
                newName: "Refeicoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refeicoes",
                table: "Refeicoes",
                column: "Id");
        }
    }
}
