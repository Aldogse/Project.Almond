using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Property_and_Supply_Management.Migrations
{
    public partial class put_notif_on_maintenance_item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNotified",
                table: "Items");

            migrationBuilder.AddColumn<bool>(
                name: "IsNotified",
                table: "MaintenanceItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNotified",
                table: "MaintenanceItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsNotified",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
