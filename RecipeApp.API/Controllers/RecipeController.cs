using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.API.Models;

namespace RecipeApp.API.Controllers;

[Route("api/recipes")]
[ApiController]
public class RecipeController : ControllerBase
{

    private RecipeDataStore _recipeDataStore;
    public RecipeController(RecipeDataStore recipeDataStore)
    {
        _recipeDataStore = recipeDataStore;
    }

    [HttpGet]
    public ActionResult<IEnumerable<RecipeDto>> GetRecipes()
    {
        return Ok(_recipeDataStore.Recipes);
    }

    [HttpGet("{recipeId}")]
    public ActionResult<RecipeDto> GetRecipe(int recipeId)
    {
        var recipe = _recipeDataStore.Recipes.FirstOrDefault(x => x.Id == recipeId);

        if (recipe == null)
        {
            return NotFound();
        }

        return Ok(recipe);
    }
}
