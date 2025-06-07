using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lost_And_Found.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tables_updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoundItem_User_UserId",
                table: "FoundItem");

            migrationBuilder.DropForeignKey(
                name: "FK_LostItems_User_UserId",
                table: "LostItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_FoundItem_FoundItemId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_User_UserId",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_FoundItem_FoundItemId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_LostItems_LostItemId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_User_UserId",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoundItem",
                table: "FoundItem");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Report",
                newName: "Reports");

            migrationBuilder.RenameTable(
                name: "FoundItem",
                newName: "FoundItems");

            migrationBuilder.RenameIndex(
                name: "IX_Report_UserId",
                table: "Reports",
                newName: "IX_Reports_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_LostItemId",
                table: "Reports",
                newName: "IX_Reports_LostItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_FoundItemId",
                table: "Reports",
                newName: "IX_Reports_FoundItemId");

            migrationBuilder.RenameIndex(
                name: "IX_FoundItem_UserId",
                table: "FoundItems",
                newName: "IX_FoundItems_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoundItems",
                table: "FoundItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoundItems_Users_UserId",
                table: "FoundItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LostItems_Users_UserId",
                table: "LostItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_FoundItems_FoundItemId",
                table: "Match",
                column: "FoundItemId",
                principalTable: "FoundItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Users_UserId",
                table: "Notification",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_FoundItems_FoundItemId",
                table: "Reports",
                column: "FoundItemId",
                principalTable: "FoundItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_LostItems_LostItemId",
                table: "Reports",
                column: "LostItemId",
                principalTable: "LostItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_UserId",
                table: "Reports",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoundItems_Users_UserId",
                table: "FoundItems");

            migrationBuilder.DropForeignKey(
                name: "FK_LostItems_Users_UserId",
                table: "LostItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_FoundItems_FoundItemId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Users_UserId",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_FoundItems_FoundItemId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_LostItems_LostItemId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_UserId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoundItems",
                table: "FoundItems");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Report");

            migrationBuilder.RenameTable(
                name: "FoundItems",
                newName: "FoundItem");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_UserId",
                table: "Report",
                newName: "IX_Report_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_LostItemId",
                table: "Report",
                newName: "IX_Report_LostItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_FoundItemId",
                table: "Report",
                newName: "IX_Report_FoundItemId");

            migrationBuilder.RenameIndex(
                name: "IX_FoundItems_UserId",
                table: "FoundItem",
                newName: "IX_FoundItem_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report",
                table: "Report",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoundItem",
                table: "FoundItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoundItem_User_UserId",
                table: "FoundItem",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LostItems_User_UserId",
                table: "LostItems",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_FoundItem_FoundItemId",
                table: "Match",
                column: "FoundItemId",
                principalTable: "FoundItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_User_UserId",
                table: "Notification",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_FoundItem_FoundItemId",
                table: "Report",
                column: "FoundItemId",
                principalTable: "FoundItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_LostItems_LostItemId",
                table: "Report",
                column: "LostItemId",
                principalTable: "LostItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_User_UserId",
                table: "Report",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
