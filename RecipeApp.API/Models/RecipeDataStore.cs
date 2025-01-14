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
                            Quality = "KEBS",
                            Unit = "500 g",
                        },
                        new IngredientDto()
                        {
                            Id= 2,
                            Name = "Black Pepper",
                            Quality = "KEBS",
                            Unit = "1/4 tablespoon",
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
                            Id= 3,
                            Name = "Meat",
                            Quality = "KEBS",
                            Unit = "1 kg",
                        },
                        new IngredientDto()
                        {
                            Id= 4,
                            Name = "Tomato",
                            Quality = "KEBS",
                            Unit = "1 tomatoes",
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
                            Id= 5,
                            Name = "Salt",
                            Quality = "KEBS",
                            Unit = "1/2 tablespoon",
                        },
                        new IngredientDto()
                        {
                            Id= 6,
                            Name = "Tumeric",
                            Quality = "KEBS",
                            Unit = "1 tablespoon",
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
                            Id= 7,
                            Name = "Olive Oil",
                            Quality = "KEBS",
                            Unit = "10 ml",
                        },
                        new IngredientDto()
                        {
                            Id= 8,
                            Name = "Tumeric",
                            Quality = "KEBS",
                            Unit = "1 tablespoon",
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
                            Id= 9,
                            Name = "Sugar",
                            Quality = "KEBS",
                            Unit = "5 full tablespoon",
                        },
                        new IngredientDto()
                        {
                            Id= 10,
                            Name = "Baking Powder",
                            Quality = "KEBS",
                            Unit = "100 g",
                        }
                    }
                }
            };
        }
    }
}
