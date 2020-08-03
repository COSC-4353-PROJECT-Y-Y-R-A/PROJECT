using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace YYRA_Team_Project.Migrations
{
    public partial class CompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //drop primary key
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quote",
                table: "Quote");

            migrationBuilder.AddColumn<int>(
                name: "UserID2",
                table: "Quote",
                nullable: true);

            migrationBuilder.Sql("update store set UserID2 = UserID");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Quote");

            migrationBuilder.RenameColumn(
                name: "UserID2",
                table: "Quote",
                newName: "UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Quote",
                nullable: false,
                oldNullable: true);

            //add QID column for comp key
            migrationBuilder.AddColumn<int>(
                name: "QID",
                table: "Quote",
                nullable: false,
                defaultValue: 0);

            //add new Comp key
            migrationBuilder.AddPrimaryKey(
                name: "PK_Quote",
                table: "Quote",
                columns: new[] { "QID", "UserID" });

            //drop misc columns
            migrationBuilder.DropColumn(
                name: "userRole",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "U_Username",
                table: "Users",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "U_Pass",
                table: "Users",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");


            //tables for other stuff
            migrationBuilder.CreateTable(
                name: "ClientInformation",
                columns: table => new
                {
                    C_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Name = table.Column<string>(maxLength: 50, nullable: true),
                    U_Address1 = table.Column<string>(maxLength: 100, nullable: true),
                    U_Address2 = table.Column<string>(maxLength: 100, nullable: true),
                    U_City = table.Column<string>(maxLength: 100, nullable: true),
                    U_State = table.Column<string>(nullable: true),
                    U_Zipcode = table.Column<string>(maxLength: 9, nullable: true),
                    U_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInformation", x => x.C_ID);
                });

            migrationBuilder.CreateTable(
                name: "UserCredentials",
                columns: table => new
                {
                    U_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Username = table.Column<string>(maxLength: 16, nullable: false),
                    U_Pass = table.Column<string>(maxLength: 16, nullable: false),
                    U_Role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCredentials", x => x.U_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientInformation");

            migrationBuilder.DropTable(
                name: "UserCredentials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quote",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "QID",
                table: "Quote");

            migrationBuilder.AlterColumn<string>(
                name: "U_Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "U_Pass",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 16);

            migrationBuilder.AddColumn<int>(
                name: "userRole",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Quote",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quote",
                table: "Quote",
                column: "UserID");
        }
    }
}
