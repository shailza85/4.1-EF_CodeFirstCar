using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "manufacturer",
                table: "code_first_car");

            migrationBuilder.AddColumn<int>(
                name: "manufacturer_id",
                table: "code_first_car",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 245327 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 155652, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 163293 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 133032, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 14223, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 174116 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 163182, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 3538 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 16827 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 134250, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 147251, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 52181, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 93552, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 99656 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 99553, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 134477, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 129015 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 214588 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 27271 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 270877, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 165629 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 22286, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 108418, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 259005, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 121177, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 176850 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 147751, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 152400 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 181501, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 276800 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 243678, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 59240, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 272086, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 287562, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 196929, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 118002, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 245526, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 287961, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 5995, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 208387 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 188999, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 37846, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 55018, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 46168, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 162379 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 25779, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 267312, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 256830, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 151372, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 245460 });

            migrationBuilder.CreateIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id",
                principalTable: "manufacturer",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropColumn(
                name: "manufacturer_id",
                table: "code_first_car");

            migrationBuilder.AddColumn<string>(
                name: "manufacturer",
                table: "code_first_car",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_general_ci");

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 246100 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 41973, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 205879 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 207146, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 108964, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Fusion", 275062 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 18302, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 157635 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Durango", 151091 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 209843, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 218038, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 244331, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 19087, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Fusion", 203919 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 10062, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 148436, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 39919 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 31052 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 214838 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 232901, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 166071 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 121950, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 297935, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 224442, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Fusion", 278492, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Fusion", 292137 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 35783, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 199589 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 73599, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Durango", 41204 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 46710, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 201183, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 280688, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 254449, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 204322, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Fusion", 254719, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 42682, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 199631, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 110542, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 275957 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 115506, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 65099, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 33868, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 255878, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 79985 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 66766, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 91811, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Fusion", 72142, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 249902, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 128732 });
        }
    }
}
