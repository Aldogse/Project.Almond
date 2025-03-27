using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Property_and_Supply_Management.Migrations
{
    public partial class add_disposed_medicine_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisposedMedications",
                columns: table => new
                {
                    drug_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MedicationType = table.Column<int>(type: "int", nullable: false),
                    medicineDisposalType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisposedMedications", x => x.drug_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisposedMedications");
        }
    }
}
