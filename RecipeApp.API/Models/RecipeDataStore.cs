namespace RecipeApp.API.Models
{
    public class RecipeDataStore
    {
        public List<RecipeDto> Recipes { get; set; }
        public static RecipeDataStore Instance { get; } = new RecipeDataStore();
        public RecipeDataStore()
        {
            Recipes = new List<RecipeDto>()
            {
                new RecipeDto
                {
                    Id = 1,
                    Name = "Hamburger",
                    Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
                    Ingredients = new List<IngredientDto>()
                    {
                        new IngredientDto()
                        {
                            Id= 1,
                            Name = "Beef",
                            Quantity = 500.00,
                            Unit = "grams",
                        },
                        new IngredientDto()
                        {
                            Id= 2,
                            Name = "Black Pepper",
                            Quantity = 0.25,
                            Unit = "tablespoon",
                        }
                    }
                },
                new RecipeDto
                {
                    Id = 2,
                    Name = "Pilau",
                    Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
                    Ingredients = new List<IngredientDto>()
                    {
                        new IngredientDto()
                        {
                            Id= 1,
                            Name = "Meat",
                            Quantity = 1.00,
                            Unit = "kg",
                        },
                        new IngredientDto()
                        {
                            Id= 2,
                            Name = "Tomato",
                            Quantity = 2.00,
                            Unit = "tomatoes",
                        }
                    }
                },
                new RecipeDto
                {
                    Id = 3,
                    Name = "Meat Stew",
                    Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
                    Ingredients = new List<IngredientDto>()
                    {
                        new IngredientDto()
                        {
                            Id= 1,
                            Name = "Salt",
                            Quantity = 1.5,
                            Unit = "tablespoon",
                        },
                        new IngredientDto()
                        {
                            Id= 2,
                            Name = "Tumeric",
                            Quantity = 1.00,
                            Unit = "tablespoon",
                        }
                    }
                },
                new RecipeDto
                {
                    Id = 4,
                    Name = "Fruit Salad",
                    Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
                    Ingredients = new List<IngredientDto>()
                    {
                        new IngredientDto()
                        {
                            Id= 1,
                            Name = "Olive Oil",
                            Quantity = 10.00,
                            Unit = "ml",
                        },
                        new IngredientDto()
                        {
                            Id= 2,
                            Name = "Tumeric",
                            Quantity = 1.00,
                            Unit = "tablespoon",
                        }
                    }
                },
                new RecipeDto
                {
                    Id = 5,
                    Name = "Brownie Cake",
                    Description = "You can add a pat of butter or some cheese to the center of each burger before cooking.\r\nYou can use almost any type of minced (ground) meat to make hamburgers, including pork, chicken, turkey, lamb, bison, venison, ostrich, or even a meat substitute such as Quorn. Some variations of hamburgers call for mixing different types of meat (e.g. ground beef and ground pork).\r\nOptional additions to burger patties prior to cooking include: black pepper, chili, Worcestershire Sauce, soy sauce, basil, oregano and parsley, minced garlic or garlic powder, onion flakes or diced onion, mustard, olive oil, cheese, butter, hot sauce, kosher salt, bread crumbs, and crushed crackers.\r\nDepending on the quality of your local beef, for example, you may wish to add some beef stock to improve the flavour. If you add any liquids, mix the ground beef well then squeeze out the extra juice when forming patties.",
                    Ingredients = new List<IngredientDto>()
                    {
                        new IngredientDto()
                        {
                            Id= 1,
                            Name = "Sugar",
                            Quantity = 5.00,
                            Unit = "tablespoon",
                        },
                        new IngredientDto()
                        {
                            Id= 2,
                            Name = "Baking Powder",
                            Quantity = 100.00,
                            Unit = "g",
                        }
                    }
                }
            };
        }
    }
}
