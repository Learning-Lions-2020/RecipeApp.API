using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeApp.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Quantity", "Unit" },
                values: new object[] { "Beef", 500.0, "grams" });

            migrationBuilder.UpdateData(
                table: "ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Quantity" },
                values: new object[] { "Tumeric", 1.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Quantity", "Unit" },
                values: new object[] { "Black Pepper", 0.25, "tablespoon" });

            migrationBuilder.UpdateData(
                table: "ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Quantity" },
                values: new object[] { "Sugar", 5.0 });
        }
    }
}
