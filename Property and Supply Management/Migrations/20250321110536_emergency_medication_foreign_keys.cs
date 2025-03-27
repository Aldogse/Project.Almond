using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Property_and_Supply_Management.Migrations
{
    public partial class emergency_medication_foreign_keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicationType",
                table: "EmergencyMedications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "department_id",
                table: "EmergencyMedications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyMedications_department_id",
                table: "EmergencyMedications",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyMedications_Departments_department_id",
                table: "EmergencyMedications",
                column: "department_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyMedications_Departments_department_id",
                table: "EmergencyMedications");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyMedications_department_id",
                table: "EmergencyMedications");

            migrationBuilder.DropColumn(
                name: "MedicationType",
                table: "EmergencyMedications");

            migrationBuilder.DropColumn(
                name: "department_id",
                table: "EmergencyMedications");
        }
    }
}
