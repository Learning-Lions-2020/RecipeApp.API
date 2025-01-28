using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.API.Models;

namespace RecipeApp.API.Controllers;

[Route("api/recipes/{recipeId}/ingredients")]
[ApiController]
public class IngredientController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<IngredientDto>> GetAllIngredients(int recipeId)
    {
        var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            return NotFound($"Recipe with ID {recipeId} was not found.");
        }

        return Ok(recipe.Ingredients);
    }

    [HttpGet("{ingredientId}", Name = "GetIngredient")]
    public ActionResult<IngredientDto> GetIngredient(int recipeId, int ingredientId)
    {
        var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            return NotFound($"Recipe with ID {recipeId} was not found.");
        }

        var ingredient = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredient == null)
        {
            return NotFound($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
        }

        return Ok(ingredient);
    }

    [HttpPost]
    public ActionResult<IngredientDto> CreateIngredient(int recipeId, [FromBody] IngredientForCreationDto ingredient)
    {
        var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            return NotFound($"Recipe with ID {recipeId} was not found.");
        }

        var maxIngredientId = recipe.Ingredients.Max(i => i.Id);
        var newIngredient = new IngredientDto
        {
            Id = ++maxIngredientId,
            Name = ingredient.Name,
            Quantity = ingredient.Quantity,
            Unit = ingredient.Unit
        };

        recipe.Ingredients.Add(newIngredient);

        return CreatedAtRoute("GetIngredient",
            new { recipeId, ingredientId = newIngredient.Id },
            newIngredient);
    }

    [HttpPut("{ingredientId}")]
    public ActionResult UpdateIngredient(int recipeId, int ingredientId, IngredientForUpdateDto ingredient)
    {
        var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            return NotFound($"Recipe with ID {recipeId} was not found.");
        }

        var ingredientToUpdate = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredientToUpdate == null)
        {
            return NotFound($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
        }

        
        ingredientToUpdate.Name = ingredient.Name;
        ingredientToUpdate.Quantity = ingredient.Quantity;
        ingredientToUpdate.Unit = ingredient.Unit;

        return NoContent();
    }

    [HttpPatch("{ingredientId}")]
    public ActionResult PartiallyUpdateIngredient(int recipeId, int ingredientId, JsonPatchDocument<IngredientForUpdateDto> patchDocument)
    {
        var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            return NotFound($"Recipe with ID {recipeId} was not found.");
        }

        var ingredientToPatch = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredientToPatch == null)
        {
            return NotFound($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
        }

        var ingredientUpdateDto = new IngredientForUpdateDto
        {
            Name = ingredientToPatch.Name,
            Quantity = ingredientToPatch.Quantity,
            Unit = ingredientToPatch.Unit
        };

        patchDocument.ApplyTo(ingredientUpdateDto, ModelState);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!TryValidateModel(ingredientUpdateDto))
        {
            return BadRequest(ModelState);
        }

        ingredientToPatch.Name = ingredientUpdateDto.Name;
        ingredientToPatch.Quantity = ingredientUpdateDto.Quantity;
        ingredientToPatch.Unit = ingredientUpdateDto.Unit;

        return NoContent();
    }

    [HttpDelete("{ingredientId}")]
    public ActionResult DeleteIngredient(int recipeId, int ingredientId)
    {
        var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            return NotFound($"Recipe with ID {recipeId} was not found.");
        }

        var ingredientToDelete = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredientToDelete == null)
        {
            return NotFound($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
        }

        recipe.Ingredients.Remove(ingredientToDelete);

        return NoContent();
    }
}
