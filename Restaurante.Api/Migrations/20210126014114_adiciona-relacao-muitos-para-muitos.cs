using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class adicionarelacaomuitosparamuitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoPrato",
                table: "Prato");

            migrationBuilder.AddColumn<int>(
                name: "PratoId",
                table: "Refeicao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoRefeicaoId",
                table: "Refeicao",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TipoPratoId",
                table: "Prato",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "RefeicaoPrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PratoId = table.Column<int>(type: "int", nullable: false),
                    RefeicaoId = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefeicaoPrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefeicaoPrato_Prato_PratoId",
                        column: x => x.PratoId,
                        principalTable: "Prato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefeicaoPrato_Refeicao_RefeicaoId",
                        column: x => x.RefeicaoId,
                        principalTable: "Refeicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Refeicao_PratoId",
                table: "Refeicao",
                column: "PratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Refeicao_TipoRefeicaoId",
                table: "Refeicao",
                column: "TipoRefeicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_RefeicaoPrato_PratoId",
                table: "RefeicaoPrato",
                column: "PratoId");

            migrationBuilder.CreateIndex(
                name: "IX_RefeicaoPrato_RefeicaoId",
                table: "RefeicaoPrato",
                column: "RefeicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoPrato",
                table: "Prato",
                column: "TipoPratoId",
                principalTable: "TipoPrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refeicao_Prato_PratoId",
                table: "Refeicao",
                column: "PratoId",
                principalTable: "Prato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoRefeicao",
                table: "Refeicao",
                column: "TipoRefeicaoId",
                principalTable: "TipoRefeicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoPrato",
                table: "Prato");

            migrationBuilder.DropForeignKey(
                name: "FK_Refeicao_Prato_PratoId",
                table: "Refeicao");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoRefeicao",
                table: "Refeicao");

            migrationBuilder.DropTable(
                name: "RefeicaoPrato");

            migrationBuilder.DropIndex(
                name: "IX_Refeicao_PratoId",
                table: "Refeicao");

            migrationBuilder.DropIndex(
                name: "IX_Refeicao_TipoRefeicaoId",
                table: "Refeicao");

            migrationBuilder.DropColumn(
                name: "PratoId",
                table: "Refeicao");

            migrationBuilder.DropColumn(
                name: "TipoRefeicaoId",
                table: "Refeicao");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPratoId",
                table: "Prato",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoPrato",
                table: "Prato",
                column: "TipoPratoId",
                principalTable: "TipoPrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
