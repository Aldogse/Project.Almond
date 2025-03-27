using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Property_and_Supply_Management.Migrations
{
    public partial class add_notify_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "drug_id",
                table: "DisposedMedications",
                newName: "disposal_id");

            migrationBuilder.AddColumn<bool>(
                name: "NotifiedByEmail",
                table: "DisposedMedications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotifiedByEmail",
                table: "DisposedMedications");

            migrationBuilder.RenameColumn(
                name: "disposal_id",
                table: "DisposedMedications",
                newName: "drug_id");
        }
    }
}
