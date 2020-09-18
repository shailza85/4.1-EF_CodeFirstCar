using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class FirstSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { -1, "Black", "Mistubishi", "Lancer", 40000, "Evolution" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: -1);
        }
    }
}
