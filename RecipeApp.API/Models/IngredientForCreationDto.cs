using System.ComponentModel.DataAnnotations;

namespace RecipeApp.API.Models;

public class IngredientForCreationDto
{
    [Required(ErrorMessage = "You should provide a name value."), MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Quantity must be non-negative.")]

    public double? Quantity { get; set; }

    [Required, MaxLength(50)]
    public string? Unit { get; set; }
}
