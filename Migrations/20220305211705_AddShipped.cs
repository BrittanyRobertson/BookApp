using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApp.Migrations
{
    public partial class AddShipped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OrderShipped",
                table: "Purchases",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderShipped",
                table: "Purchases");
        }
    }
}
