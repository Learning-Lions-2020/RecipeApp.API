namespace RecipeApp.API.Models
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int NumberOfIngridients 
        {
            get
            {
                return Ingredients.Count;
            } 
        }
        public ICollection<IngredientDto> Ingredients { get; set; } = new List<IngredientDto>();
    }
}
