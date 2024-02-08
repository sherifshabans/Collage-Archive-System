using Microsoft.EntityFrameworkCore.Migrations;

namespace Archive2.Migrations
{
    public partial class addListUserMsg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListUserMes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListUserMes", x => new { x.UserId, x.MessageId });
                    table.ForeignKey(
                        name: "FK_ListUserMes_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListUserMes_UserAccs_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccs",
                        principalColumn: "UserAccID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListUserMes_MessageId",
                table: "ListUserMes",
                column: "MessageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListUserMes");
        }
    }
}
