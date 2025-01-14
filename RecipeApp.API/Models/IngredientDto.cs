namespace RecipeApp.API.Models
{
    public class IngredientDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Quality { get; set; }

        public string? Unit { get; set; }
    }
}
