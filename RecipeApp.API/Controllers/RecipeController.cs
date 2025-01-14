using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.API.Models;

namespace RecipeApp.API.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<RecipeDto>> GetRecipes()
        {
            return Ok(RecipeDataStore.Instance.Recipes);
        }

        [HttpGet("{recipeId}")]
        public ActionResult<RecipeDto> GetRecipe(int recipeId)
        {
            var recipeToReturn = RecipeDataStore.Instance.Recipes.FirstOrDefault(x => x.Id == recipeId);

            if (recipeToReturn == null)
            {
                return NotFound(recipeToReturn);
            }

            return Ok(recipeToReturn);
        }
    }
}
