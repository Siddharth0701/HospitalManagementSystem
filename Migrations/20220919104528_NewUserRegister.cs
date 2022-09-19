using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalManagementSystem.Migrations
{
    public partial class NewUserRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewUserRegister",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emailid = table.Column<string>(maxLength: 50, nullable: true),
                    Username = table.Column<string>(maxLength: 20, nullable: true),
                    Mobilenumber = table.Column<string>(maxLength: 20, nullable: true),
                    Dateofbirth = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(maxLength: 20, nullable: true),
                    Confirmpassword = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewUserRegister", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewUserRegister");
        }
    }
}
