using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Api.Migrations
{
    public partial class migrationalterandodadossemrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Refeicao",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 16, 20, 49, 59, 977, DateTimeKind.Local).AddTicks(4866),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 16, 20, 48, 2, 642, DateTimeKind.Local).AddTicks(7021));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Refeicao",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 16, 20, 48, 2, 642, DateTimeKind.Local).AddTicks(7021),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 16, 20, 49, 59, 977, DateTimeKind.Local).AddTicks(4866));
        }
    }
}
