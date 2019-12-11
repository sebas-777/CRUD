using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BioHealthy.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nvarchar250 = table.Column<string>(name: "nvarchar(250)", nullable: true),
                    varchar30 = table.Column<string>(name: "varchar(30)", nullable: true),
                    varchar20 = table.Column<int>(name: "varchar(20)", nullable: false),
                    nvarchar50 = table.Column<string>(name: "nvarchar(50)", nullable: true),
                    varchar25 = table.Column<string>(name: "varchar(25)", nullable: true),
                    date15 = table.Column<DateTime>(name: "date(15)", nullable: false),
                    date10 = table.Column<DateTime>(name: "date(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
