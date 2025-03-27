using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Property_and_Supply_Management.Migrations
{
    public partial class add_notification_row_for_query : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNotified",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNotified",
                table: "Items");
        }
    }
}
