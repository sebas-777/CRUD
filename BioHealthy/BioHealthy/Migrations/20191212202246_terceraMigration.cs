using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BioHealthy.Migrations
{
    public partial class terceraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date(10)",
                table: "Empleados");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(30)",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "varchar(25)",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50)",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(250)",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "varchar(30)",
                table: "Empleados",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "varchar(25)",
                table: "Empleados",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50)",
                table: "Empleados",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(250)",
                table: "Empleados",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "date(10)",
                table: "Empleados",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
