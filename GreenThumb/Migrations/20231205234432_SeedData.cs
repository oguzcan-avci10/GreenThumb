using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "instruction_id", "instruction_info", "plant_id" },
                values: new object[,]
                {
                    { 1, "Watering the plant", 1 },
                    { 2, "Put them in sunlight if you have them indoors.", 2 },
                    { 3, "During fall and winter, you can water them less often.", 3 },
                    { 4, "Provide 1 to 2 inches (2.5 to 5.1 cm) of water each week.", 3 }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "plant_id", "description", "name" },
                values: new object[,]
                {
                    { 6, "Bamboo is a type of fast-growing grass that is known for its strength and versatility.", "Bamboo" },
                    { 7, "Ivy is a type of climbing plant that can grow on walls, trees, and other surfaces.", "Ivy" },
                    { 8, "A palm tree is a type of tropical tree with a tall, slender trunk.", "Palm Tree" },
                    { 9, "Bushes are often used for landscaping and can provide a natural barrier or privacy screen.", "Bush" },
                    { 10, "Corn is a type of cereal grain that is grown for its edible seeds.", "Corn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "plant_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "plant_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "plant_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "plant_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "plant_id",
                keyValue: 10);
        }
    }
}
