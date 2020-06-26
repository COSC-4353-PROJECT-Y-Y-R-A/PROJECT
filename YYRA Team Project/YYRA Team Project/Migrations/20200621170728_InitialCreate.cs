using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YYRA_Team_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Q_Gallons = table.Column<int>(nullable: false),
                    Q_Address = table.Column<string>(nullable: true),
                    Q_Date = table.Column<DateTime>(nullable: false),
                    Q_Price = table.Column<float>(nullable: false),
                    Q_Total = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
