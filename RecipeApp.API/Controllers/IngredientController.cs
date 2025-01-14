using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.API.Models;

namespace RecipeApp.API.Controllers
{
    [Route("api/recipes/{recipeId}/ingridients")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<IngredientDto>> GetAllIngredients(int recipeId)
        {
            var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe.Ingredients);
        }

        [HttpGet("{ingredientId}")]

        public ActionResult<IngredientDto> GetIngredient(int recipeId, int ingredientId)
        {
            var recipe = RecipeDataStore.Instance.Recipes.FirstOrDefault(r => r.Id == recipeId);

            if (recipe == null)
            {
                return NotFound();
            }

            var ingridients = RecipeDataStore.Instance.Recipes.FirstOrDefault(i => i.Id == ingredientId);

            if(ingridients == null) 
            { 
                return NotFound(); 
            }

            return Ok(recipe.Ingredients);
        }
    }
}
