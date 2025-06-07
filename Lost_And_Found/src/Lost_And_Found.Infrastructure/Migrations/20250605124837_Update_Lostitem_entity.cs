using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lost_And_Found.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_Lostitem_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFound",
                table: "LostItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFound",
                table: "LostItems");
        }
    }
}
