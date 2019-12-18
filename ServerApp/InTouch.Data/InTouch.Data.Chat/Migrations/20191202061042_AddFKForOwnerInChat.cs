using Microsoft.EntityFrameworkCore.Migrations;

namespace InTouch.Data.Chat.Migrations
{
    public partial class AddFKForOwnerInChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Chats_OwnerId",
                table: "Chats",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_People_OwnerId",
                table: "Chats",
                column: "OwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_People_OwnerId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_OwnerId",
                table: "Chats");
        }
    }
}
