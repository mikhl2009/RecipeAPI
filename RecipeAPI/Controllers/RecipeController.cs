using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Core.Interfaces;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpPost]
        public IActionResult AddRecipe( RecipeCreateDTO recipeCreateDTO)
        {
            _recipeService.AddRecipe(recipeCreateDTO);
            return Ok("Receptet är tillagt");
        }

        [HttpGet]
        public IActionResult GetAllRecipes()
        {
            var recipes = _recipeService.GetAllRecipes();
            return Ok(recipes);
        }


        [HttpGet]
        [Route("search")]
        public IActionResult SearchRecipes(string name)
        {
            var recipes = _recipeService.SearchRecipes(name);
            return Ok(recipes);
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateRecipe(RecipeUpdateDTO recipeUpdateDTO)
        {
            var recipe = _recipeService.GetRecipeById(recipeUpdateDTO.RecipeId);
            if (recipe == null)
            {
                return NotFound(" Receptet finns inte");
            }
            if (recipe.UserId != recipeUpdateDTO.UserId)
            {
                return NotFound( "Du har inte behörighet att uppdatera detta recept");
            }
            _recipeService.UpdateRecipe(recipeUpdateDTO);
            return Ok("Receptet är uppdaterat");
        }

        [HttpGet]
        [Route("delete")]
        public IActionResult DeleteRecipe(int RecipeId, int UserId)
        {
            var recipe = _recipeService.GetRecipeById(RecipeId);
            if (recipe == null)
            {
                return NotFound();
            }
            if (recipe.UserId != UserId)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            _recipeService.DeleteRecipe(RecipeId, UserId);
            return Ok("Receptet är borttaget");

        }

    }
        
}
