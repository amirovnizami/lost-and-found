using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lost_And_Found.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Reward_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reward",
                table: "LostItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reward",
                table: "LostItems");
        }
    }
}
