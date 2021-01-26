using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class terminandorelacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefeicaoPrato_Prato_PratoId",
                table: "RefeicaoPrato");

            migrationBuilder.DropForeignKey(
                name: "FK_RefeicaoPrato_Refeicao_RefeicaoId",
                table: "RefeicaoPrato");

            migrationBuilder.CreateTable(
                name: "PratoAdicional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PratoId = table.Column<int>(type: "int", nullable: false),
                    AdicionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PratoAdicional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PratoAdicional_Adicional",
                        column: x => x.AdicionalId,
                        principalTable: "Adicional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PratoAdicional_Prato",
                        column: x => x.PratoId,
                        principalTable: "Prato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PratoOpcao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PratoId = table.Column<int>(type: "int", nullable: false),
                    OpcaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PratoOpcao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PratoOpcao_Opcao",
                        column: x => x.OpcaoId,
                        principalTable: "Opcao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PratoOpcao_Prato",
                        column: x => x.PratoId,
                        principalTable: "Prato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PratoAdicional_AdicionalId",
                table: "PratoAdicional",
                column: "AdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_PratoAdicional_PratoId",
                table: "PratoAdicional",
                column: "PratoId");

            migrationBuilder.CreateIndex(
                name: "IX_PratoOpcao_OpcaoId",
                table: "PratoOpcao",
                column: "OpcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PratoOpcao_PratoId",
                table: "PratoOpcao",
                column: "PratoId");

            migrationBuilder.AddForeignKey(
                name: "FK_RefeicaoPrato_Prato",
                table: "RefeicaoPrato",
                column: "PratoId",
                principalTable: "Prato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefeicaoPrato_Refeicao",
                table: "RefeicaoPrato",
                column: "RefeicaoId",
                principalTable: "Refeicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefeicaoPrato_Prato",
                table: "RefeicaoPrato");

            migrationBuilder.DropForeignKey(
                name: "FK_RefeicaoPrato_Refeicao",
                table: "RefeicaoPrato");

            migrationBuilder.DropTable(
                name: "PratoAdicional");

            migrationBuilder.DropTable(
                name: "PratoOpcao");

            migrationBuilder.AddForeignKey(
                name: "FK_RefeicaoPrato_Prato_PratoId",
                table: "RefeicaoPrato",
                column: "PratoId",
                principalTable: "Prato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefeicaoPrato_Refeicao_RefeicaoId",
                table: "RefeicaoPrato",
                column: "RefeicaoId",
                principalTable: "Refeicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
