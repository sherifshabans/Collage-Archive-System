using Microsoft.EntityFrameworkCore.Migrations;

namespace Archive2.Migrations
{
    public partial class addKeytoUserAcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserAccId",
                table: "UserAccs",
                newName: "UserAccID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserAccID",
                table: "UserAccs",
                newName: "UserAccId");
        }
    }
}
