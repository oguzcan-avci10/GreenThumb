using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class MoreInstructions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "instruction_id", "instruction_info", "plant_id" },
                values: new object[,]
                {
                    { 14, "During fall and winter, you can water them less often.", 7 },
                    { 15, "Put them in sunlight if you have them indoors.", 7 },
                    { 16, "During fall and winter, you can water them less often.", 6 },
                    { 17, "Put them in sunlight if you have them indoors.", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 17);
        }
    }
}
