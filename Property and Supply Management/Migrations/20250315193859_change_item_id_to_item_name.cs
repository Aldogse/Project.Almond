using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Property_and_Supply_Management.Migrations
{
    public partial class change_item_id_to_item_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisposedItems_Items_item_id",
                table: "DisposedItems");

            migrationBuilder.DropIndex(
                name: "IX_DisposedItems_item_id",
                table: "DisposedItems");

            migrationBuilder.DropColumn(
                name: "item_id",
                table: "DisposedItems");

            migrationBuilder.AddColumn<string>(
                name: "item_name",
                table: "DisposedItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item_name",
                table: "DisposedItems");

            migrationBuilder.AddColumn<int>(
                name: "item_id",
                table: "DisposedItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DisposedItems_item_id",
                table: "DisposedItems",
                column: "item_id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisposedItems_Items_item_id",
                table: "DisposedItems",
                column: "item_id",
                principalTable: "Items",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
