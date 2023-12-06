using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class AddedInstructions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "instruction_id", "instruction_info", "plant_id" },
                values: new object[,]
                {
                    { 5, "Watering the plant", 10 },
                    { 6, "Put them in sunlight if you have them indoors.", 2 },
                    { 7, "During fall and winter, you can water them less often.", 2 },
                    { 8, "Watering the plant", 9 },
                    { 9, "During fall and winter, you can water them less often.", 4 },
                    { 10, "Put them in sunlight if you have them indoors.", 4 },
                    { 11, "During fall and winter, you can water them less often.", 5 },
                    { 12, "During fall and winter, you can water them less often.", 8 },
                    { 13, "Watering the plant", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 13);
        }
    }
}
