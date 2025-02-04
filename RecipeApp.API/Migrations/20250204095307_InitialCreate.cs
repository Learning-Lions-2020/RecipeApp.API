using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipeApp.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<double>(type: "float", maxLength: 50, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ingredients_recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "recipes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.", "Hamburger" },
                    { 2, "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.", "Pilau" },
                    { 3, "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.", "Meat Stew" },
                    { 4, "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.", "Fruit Salad" },
                    { 5, "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.", "Brownie Cake" }
                });

            migrationBuilder.InsertData(
                table: "ingredients",
                columns: new[] { "Id", "Name", "Quantity", "RecipeId", "Unit" },
                values: new object[,]
                {
                    { 1, "Black Pepper", 0.25, 1, "tablespoon" },
                    { 2, "Black Pepper", 0.25, 1, "tablespoon" },
                    { 3, "Meat", 1.0, 2, "kg" },
                    { 4, "Tomato", 2.0, 2, "tomatoes" },
                    { 5, "Salt", 1.5, 3, "tablespoon" },
                    { 6, "Sugar", 5.0, 3, "tablespoon" },
                    { 7, "Olive Oil", 10.0, 4, "ml" },
                    { 8, "Tumeric", 1.0, 4, "tablespoon" },
                    { 9, "Sugar", 5.0, 5, "tablespoon" },
                    { 10, "Baking Powder", 100.0, 5, "g" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ingredients_RecipeId",
                table: "ingredients",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ingredients");

            migrationBuilder.DropTable(
                name: "recipes");
        }
    }
}
