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
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Q_Gallons = table.Column<int>(nullable: false),
                    Q_Address = table.Column<string>(nullable: true),
                    Q_Date = table.Column<string>(nullable: true),
                    Q_Price = table.Column<float>(nullable: false),
                    Q_Total = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Username = table.Column<string>(nullable: false),
                    U_Pass = table.Column<string>(nullable: false),
                    U_FullName = table.Column<string>(maxLength: 50, nullable: true),
                    U_Address1 = table.Column<string>(maxLength: 100, nullable: true),
                    U_Address2 = table.Column<string>(maxLength: 100, nullable: true),
                    U_City = table.Column<string>(maxLength: 100, nullable: true),
                    U_State = table.Column<string>(nullable: true),
                    U_Zipcode = table.Column<string>(maxLength: 9, nullable: true),
                    U_Email = table.Column<string>(nullable: true),
                    U_Role = table.Column<string>(nullable: false),
                    userRole = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
