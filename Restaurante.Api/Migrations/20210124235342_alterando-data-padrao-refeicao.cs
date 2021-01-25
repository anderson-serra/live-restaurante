using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class alterandodatapadraorefeicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Refeicao",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 16, 21, 5, 56, 840, DateTimeKind.Local).AddTicks(294));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Refeicao",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 16, 21, 5, 56, 840, DateTimeKind.Local).AddTicks(294),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
