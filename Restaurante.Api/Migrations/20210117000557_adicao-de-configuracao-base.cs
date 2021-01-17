using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class adicaodeconfiguracaobase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoRefeicoes",
                table: "TipoRefeicoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPratos",
                table: "TipoPratos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pratos",
                table: "Pratos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opcoes",
                table: "Opcoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adicionais",
                table: "Adicionais");

            migrationBuilder.RenameTable(
                name: "TipoRefeicoes",
                newName: "TipoRefeicao");

            migrationBuilder.RenameTable(
                name: "TipoPratos",
                newName: "TipoPrato");

            migrationBuilder.RenameTable(
                name: "Pratos",
                newName: "Prato");

            migrationBuilder.RenameTable(
                name: "Opcoes",
                newName: "Opcao");

            migrationBuilder.RenameTable(
                name: "Adicionais",
                newName: "Adicional");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Refeicao",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 16, 21, 5, 56, 840, DateTimeKind.Local).AddTicks(294),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 16, 20, 49, 59, 977, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "TipoRefeicao",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "TipoRefeicao",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "TipoPrato",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "TipoPrato",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Prato",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Prato",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Opcao",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Opcao",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Adicional",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Adicional",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoRefeicao",
                table: "TipoRefeicao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPrato",
                table: "TipoPrato",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prato",
                table: "Prato",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opcao",
                table: "Opcao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adicional",
                table: "Adicional",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoRefeicao",
                table: "TipoRefeicao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPrato",
                table: "TipoPrato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prato",
                table: "Prato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opcao",
                table: "Opcao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adicional",
                table: "Adicional");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "TipoRefeicao");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "TipoRefeicao");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "TipoPrato");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "TipoPrato");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Prato");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Prato");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Opcao");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Opcao");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Adicional");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Adicional");

            migrationBuilder.RenameTable(
                name: "TipoRefeicao",
                newName: "TipoRefeicoes");

            migrationBuilder.RenameTable(
                name: "TipoPrato",
                newName: "TipoPratos");

            migrationBuilder.RenameTable(
                name: "Prato",
                newName: "Pratos");

            migrationBuilder.RenameTable(
                name: "Opcao",
                newName: "Opcoes");

            migrationBuilder.RenameTable(
                name: "Adicional",
                newName: "Adicionais");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Refeicao",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 16, 20, 49, 59, 977, DateTimeKind.Local).AddTicks(4866),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 16, 21, 5, 56, 840, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoRefeicoes",
                table: "TipoRefeicoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPratos",
                table: "TipoPratos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pratos",
                table: "Pratos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opcoes",
                table: "Opcoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adicionais",
                table: "Adicionais",
                column: "Id");
        }
    }
}
