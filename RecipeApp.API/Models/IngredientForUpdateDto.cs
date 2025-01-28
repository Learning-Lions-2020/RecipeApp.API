using System.ComponentModel.DataAnnotations;

namespace RecipeApp.API.Models
{
    public class IngredientForUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public double? Quantity { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Unit { get; set; }
    }
}
