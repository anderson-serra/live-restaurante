using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class migrationalterandodados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Refeicao",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Refeicao",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 16, 20, 48, 2, 642, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.AddColumn<string>(
                name: "NomeRefeicao",
                table: "Refeicao",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Refeicao");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Refeicao");

            migrationBuilder.DropColumn(
                name: "NomeRefeicao",
                table: "Refeicao");
        }
    }
}
