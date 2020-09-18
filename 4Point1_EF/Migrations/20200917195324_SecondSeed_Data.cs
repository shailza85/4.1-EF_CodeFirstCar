using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class SecondSeed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: -1);

            migrationBuilder.CreateTable(
                name: "manufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    year_founded = table.Column<int>(type: "int(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturer", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Black", "Dodge", "Fusion", 246100, "R/T" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[,]
                {
                    { 29, "Black", "Dodge", "Corvette", 73599, "R/T" },
                    { 31, "Black", "Ford", "Corvette", 46710, "Awesome" },
                    { 32, "Black", "Ford", "Corvette", 201183, "R/T" },
                    { 33, "Black", "Chevrolet", "Corvette", 280688, "R/T" },
                    { 34, "Black", "Dodge", "Corvette", 254449, "High Country" },
                    { 35, "Black", "Chevrolet", "Corvette", 204322, "R/T" },
                    { 36, "Black", "Chevrolet", "Fusion", 254719, "Awesome" },
                    { 37, "Black", "Dodge", "Durango", 42682, "R/T" },
                    { 38, "Black", "Ford", "Fusion", 199631, "R/T" },
                    { 39, "Black", "Chevrolet", "Corvette", 110542, "High Country" },
                    { 40, "Black", "Ford", "Fusion", 275957, "High Country" },
                    { 41, "Black", "Dodge", "Durango", 115506, "Awesome" },
                    { 42, "Black", "Ford", "Corvette", 65099, "High Country" },
                    { 43, "Black", "Ford", "Durango", 33868, "High Country" },
                    { 44, "Black", "Chevrolet", "Corvette", 255878, "Awesome" },
                    { 45, "Black", "Dodge", "Fusion", 79985, "R/T" },
                    { 46, "Black", "Dodge", "Durango", 66766, "Awesome" },
                    { 47, "Black", "Ford", "Fusion", 91811, "Awesome" },
                    { 48, "Black", "Chevrolet", "Fusion", 72142, "Awesome" },
                    { 49, "Black", "Ford", "Durango", 249902, "High Country" },
                    { 50, "Black", "Chevrolet", "Corvette", 128732, "Awesome" },
                    { 28, "Black", "Ford", "Durango", 199589, "High Country" },
                    { 27, "Black", "Chevrolet", "Corvette", 35783, "High Country" },
                    { 30, "Black", "Dodge", "Durango", 41204, "Awesome" },
                    { 25, "Black", "Chevrolet", "Fusion", 278492, "High Country" },
                    { 3, "Black", "Dodge", "Fusion", 205879, "R/T" },
                    { 4, "Black", "Dodge", "Fusion", 207146, "R/T" },
                    { 5, "Black", "Dodge", "Corvette", 108964, "High Country" },
                    { 6, "Black", "Chevrolet", "Fusion", 275062, "R/T" },
                    { 7, "Black", "Ford", "Durango", 18302, "High Country" },
                    { 8, "Black", "Chevrolet", "Corvette", 157635, "R/T" },
                    { 9, "Black", "Chevrolet", "Durango", 151091, "High Country" },
                    { 26, "Black", "Dodge", "Fusion", 292137, "High Country" },
                    { 11, "Black", "Chevrolet", "Durango", 218038, "High Country" },
                    { 12, "Black", "Ford", "Fusion", 244331, "Awesome" },
                    { 13, "Black", "Ford", "Durango", 19087, "High Country" },
                    { 10, "Black", "Dodge", "Durango", 209843, "R/T" },
                    { 15, "Black", "Dodge", "Durango", 10062, "High Country" },
                    { 24, "Black", "Dodge", "Corvette", 224442, "High Country" },
                    { 14, "Black", "Dodge", "Fusion", 203919, "High Country" },
                    { 22, "Black", "Ford", "Corvette", 121950, "High Country" },
                    { 21, "Black", "Dodge", "Corvette", 166071, "High Country" },
                    { 23, "Black", "Chevrolet", "Durango", 297935, "High Country" },
                    { 19, "Black", "Ford", "Corvette", 214838, "High Country" },
                    { 18, "Black", "Ford", "Fusion", 31052, "High Country" },
                    { 17, "Black", "Dodge", "Fusion", 39919, "R/T" },
                    { 16, "Black", "Dodge", "Durango", 148436, "High Country" },
                    { 20, "Black", "Dodge", "Fusion", 232901, "High Country" },
                    { 2, "Black", "Dodge", "Durango", 41973, "R/T" }
                });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "id", "name", "year_founded" },
                values: new object[,]
                {
                    { 8, "Nissan", null },
                    { 1, "Chevrolet", 1911 },
                    { 2, "Ford", 1903 },
                    { 3, "Tesla", null },
                    { 4, "Dodge", null },
                    { 5, "Toyota", 1937 },
                    { 6, "Honda", 1946 },
                    { 7, "Mitsubishi", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "manufacturer");

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Red", "Honda", "Civic", 11000, "LX" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { -1, "Black", "Mistubishi", "Lancer", 40000, "Evolution" });
        }
    }
}
