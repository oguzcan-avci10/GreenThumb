using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class DeleteAndRecreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 1,
                column: "instruction_info",
                value: "Water the plant");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 2,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Your plant should flower after about 8 weeks.", 1 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 3,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Watering infrequently. They're a desert plant. Dry soil suits them fine", 2 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 4,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Keep your plant in a bright, sunny spot", 2 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 5,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Keep your plant in a bright, sunny spot", 3 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 6,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Provide 1 to 2 inches (2.5 to 5cm) of water each week", 3 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 7,
                column: "plant_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 8,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "During fall and winter, you can water them less often.", 5 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 9,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Mow New Grass and Control Weeds", 5 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 10,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Water thoroughly once or twice a week depending on weather conditions.", 6 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 11,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "For a healthy grove of timber bamboo, remove old, dead, weak and leaning canes,", 6 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 12,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Keep your plant in a bright, sunny spot", 7 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 13,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "4 feet tall: Apply 2 pounds of fertilizer ", 8 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 14,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "10 feet tall: Apply 5 pounds of fertilizer ", 8 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 15,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "20 feet tall: Apply 10 pounds of fertilizer", 8 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 16,
                column: "plant_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 17,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "The ideal indoor location for this plant is near a window with filtered sunlight.", 10 });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "instruction_id", "instruction_info", "plant_id" },
                values: new object[] { 18, "Keep the soil evenly moist but not soggy during the growing season.", 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 1,
                column: "instruction_info",
                value: "Watering the plant");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 2,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Put them in sunlight if you have them indoors.", 2 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 3,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "During fall and winter, you can water them less often.", 3 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 4,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Provide 1 to 2 inches (2.5 to 5.1 cm) of water each week.", 3 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 5,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Watering the plant", 10 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 6,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Put them in sunlight if you have them indoors.", 2 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 7,
                column: "plant_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 8,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Watering the plant", 9 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 9,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "During fall and winter, you can water them less often.", 4 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 10,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Put them in sunlight if you have them indoors.", 4 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 11,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "During fall and winter, you can water them less often.", 5 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 12,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "During fall and winter, you can water them less often.", 8 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 13,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Watering the plant", 9 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 14,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "During fall and winter, you can water them less often.", 7 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 15,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Put them in sunlight if you have them indoors.", 7 });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 16,
                column: "plant_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "instruction_id",
                keyValue: 17,
                columns: new[] { "instruction_info", "plant_id" },
                values: new object[] { "Put them in sunlight if you have them indoors.", 6 });
        }
    }
}
