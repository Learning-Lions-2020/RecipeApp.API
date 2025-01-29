using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.API.Models;
using RecipeApp.API.Services;

namespace RecipeApp.API.Controllers;

[Route("api/recipes/{recipeId}/ingredients")]
[ApiController]
public class IngredientController : ControllerBase
{

    private ILogger<IngredientController> _logger;
    private RecipeDataStore _recipeDataStore;
    private IMailService _mailService;

    public IngredientController(ILogger<IngredientController> logger, RecipeDataStore recipeDataStore, IMailService mailService)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _recipeDataStore = recipeDataStore ?? throw new ArgumentNullException(nameof(_recipeDataStore));
        _mailService = mailService ?? throw new ArgumentNullException(nameof(_mailService));
    }

    [HttpGet]
    public ActionResult<IEnumerable<IngredientDto>> GetAllIngredients(int recipeId)
    {
            var recipe = _recipeDataStore.Recipes.FirstOrDefault(r => r.Id == recipeId);

            if (recipe == null)
            {
                _logger.LogInformation($"Recipe with id {recipeId} wasn't found when accessing all ingredients.");
                return NotFound();
            }

            return Ok(recipe.Ingredients);
    }

    [HttpGet("{ingredientId}", Name = "GetIngredient")]
    public ActionResult<IngredientDto> GetIngredient(int recipeId, int ingredientId)
    {
        var recipe = _recipeDataStore.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            _logger.LogInformation($"Recipe with id {recipeId} wasn't found when accessing all ingredients.");
            return NotFound();
        }

        var ingredient = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredient == null)
        {
            _logger.LogWarning($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
            return NotFound();
        }

        return Ok(ingredient);
    }

    [HttpPost]
    public ActionResult<IngredientDto> CreateIngredient(int recipeId, [FromBody] IngredientForCreationDto ingredient)
    {
        var recipe = _recipeDataStore.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            _logger.LogWarning($"Recipe with ID {recipeId} was not found while accessing ingredients.");
            return NotFound();
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

        _logger.LogInformation($"Ingredient with ID {maxIngredientId} created for Recipe ID {recipeId}.");
        return CreatedAtRoute("GetIngredient",
            new { recipeId, ingredientId = newIngredient.Id },
            newIngredient);
    }

    [HttpPut("{ingredientId}")]
    public ActionResult UpdateIngredient(int recipeId, int ingredientId, IngredientForUpdateDto ingredient)
    {
        var recipe = _recipeDataStore.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            _logger.LogWarning($"Recipe with ID {recipeId} was not found while accessing ingredients.");
            return NotFound();
        }

        var ingredientToUpdate = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredientToUpdate == null)
        {
            _logger.LogWarning($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
            return NotFound();
        }


        ingredientToUpdate.Name = ingredient.Name;
        ingredientToUpdate.Quantity = ingredient.Quantity;
        ingredientToUpdate.Unit = ingredient.Unit;

        _logger.LogInformation($"Ingredient with ID {ingredientId} updated for Recipe ID {recipeId}.");
        return NoContent();
    }

    [HttpPatch("{ingredientId}")]
    public ActionResult PartiallyUpdateIngredient(int recipeId, int ingredientId, JsonPatchDocument<IngredientForUpdateDto> patchDocument)
    {
        var recipe = _recipeDataStore.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            _logger.LogWarning($"Recipe with ID {recipeId} was not found while accessing ingredients.");
            return NotFound();
        }

        var ingredientToPatch = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredientToPatch == null)
        {
            _logger.LogWarning($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
            return NotFound();
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

        _logger.LogInformation($"Ingredient with ID {ingredientId} updated for Recipe ID {recipeId}.");
        return NoContent();
    }

    [HttpDelete("{ingredientId}")]
    public ActionResult DeleteIngredient(int recipeId, int ingredientId)
    {
        var recipe = _recipeDataStore.Recipes.FirstOrDefault(r => r.Id == recipeId);

        if (recipe == null)
        {
            _logger.LogWarning($"Recipe with ID {recipeId} was not found while accessing ingredients.");
            return NotFound();
        }

        var ingredientToDelete = recipe.Ingredients.FirstOrDefault(i => i.Id == ingredientId);

        if (ingredientToDelete == null)
        {
            _logger.LogWarning($"Ingredient with ID {ingredientId} was not found in Recipe {recipeId}.");
            return NotFound();
        }

        recipe.Ingredients.Remove(ingredientToDelete);

        _mailService.send("Ingredient deleted.", $"ingredient {ingredientToDelete.Name} with id {ingredientId} has been removed.");
        return NoContent();
    }
}
