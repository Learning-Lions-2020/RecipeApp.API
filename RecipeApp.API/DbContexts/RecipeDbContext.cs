using Microsoft.EntityFrameworkCore;
using RecipeApp.API.Entities;

namespace RecipeApp.API.DbContexts;

public class RecipeDbContext : DbContext
{
    public DbSet<Recipe> recipes { get; set; }
    public DbSet<Ingredient> ingredients { get; set; }

    public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>()
            .HasData(
            new Recipe("Hamburger")
            {
                Id = 1,
                Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
            },
            new Recipe("Pilau")
            {
                Id = 2,
                Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
            },
            new Recipe("Meat Stew")
            {
                Id = 3,
                Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
            },
            new Recipe("Fruit Salad")
            {
                Id = 4,
                Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
            },
            new Recipe("Brownie Cake")
            {
                Id = 5,
                Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
            });
        modelBuilder.Entity<Ingredient>()
            .HasData(
            new Ingredient("Beef")
            {
                Id = 1,
                RecipeId = 1,
                Quantity = 500.00,
                Unit = "grams",
            },
            new Ingredient("Black Pepper")
            {
                Id = 2,
                RecipeId = 1,
                Quantity = 0.25,
                Unit = "tablespoon",
            },
            new Ingredient("Meat")
            {
                Id = 3,
                RecipeId = 2,
                Quantity = 1.00,
                Unit = "kg",
            },
            new Ingredient("Tomato")
            {
                Id = 4,
                RecipeId = 2,
                Quantity = 2.00,
                Unit = "tomatoes",
            },
            new Ingredient("Salt")
            {
                Id = 5,
                RecipeId = 3,
                Quantity = 1.5,
                Unit = "tablespoon",
            },
            new Ingredient("Tumeric")
            {
                Id = 6,
                RecipeId = 3,
                Quantity = 1.00,
                Unit = "tablespoon",
            },
            new Ingredient("Olive Oil")
            {
                Id = 7,
                RecipeId = 4,
                Quantity = 10.00,
                Unit = "ml",
            },
            new Ingredient("Tumeric")
            {
                Id = 8,
                RecipeId = 4,
                Quantity = 1.00,
                Unit = "tablespoon",
            },
            new Ingredient("Sugar")
            {
                Id = 9,
                RecipeId = 5,
                Quantity = 5.00,
                Unit = "tablespoon",
            },
            new Ingredient("Baking Powder")
            {
                Id = 10,
                RecipeId = 5,
                Quantity = 100.00,
                Unit = "g",
            });
        base.OnModelCreating(modelBuilder);
    }
}
