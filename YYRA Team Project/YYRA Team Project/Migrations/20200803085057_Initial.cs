using Microsoft.EntityFrameworkCore.Migrations;

namespace YYRA_Team_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientInformation",
                columns: table => new
                {
                    C_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Name = table.Column<string>(maxLength: 50, nullable: false),
                    U_Address1 = table.Column<string>(maxLength: 100, nullable: false),
                    U_Address2 = table.Column<string>(maxLength: 100, nullable: true),
                    U_City = table.Column<string>(maxLength: 100, nullable: false),
                    U_State = table.Column<string>(nullable: true),
                    U_Zipcode = table.Column<string>(maxLength: 9, nullable: false),
                    U_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInformation", x => x.C_ID);
                });

            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    QID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Q_Gallons = table.Column<int>(nullable: false),
                    Q_Address = table.Column<string>(nullable: true),
                    Q_Date = table.Column<string>(nullable: false),
                    Q_Price = table.Column<float>(nullable: false),
                    Q_Total = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => new { x.QID, x.UserID });
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Username = table.Column<string>(maxLength: 16, nullable: false),
                    U_Pass = table.Column<string>(maxLength: 16, nullable: false),
                    U_FullName = table.Column<string>(maxLength: 50, nullable: true),
                    U_Address1 = table.Column<string>(maxLength: 100, nullable: true),
                    U_Address2 = table.Column<string>(maxLength: 100, nullable: true),
                    U_City = table.Column<string>(maxLength: 100, nullable: true),
                    U_State = table.Column<string>(nullable: true),
                    U_Zipcode = table.Column<string>(maxLength: 9, nullable: true),
                    U_Email = table.Column<string>(nullable: true),
                    U_Role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientInformation");

            migrationBuilder.DropTable(
                name: "Quote");

            migrationBuilder.DropTable(
                name: "UserCredentials");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
