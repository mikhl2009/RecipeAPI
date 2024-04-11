using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Core.Interfaces;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        private readonly IRecipeService _recipeService;

        public RatingController(IRatingService ratingService, IRecipeService recipeService)
        {
            _ratingService = ratingService;
            _recipeService = recipeService;
        }

        [HttpPost("AddRating 1-5")]
        public IActionResult AddRating(RatingDTO ratingDTO)
        {
            if (ratingDTO.Score < 1 || ratingDTO.Score > 5)
            {
                return BadRequest("Betyget måste vara mellan 1 och 5");
            }
            var recipe = _recipeService.GetRecipeById(ratingDTO.RecipeId);
            if (recipe == null)
            {
                return NotFound("Receptet finns inte");
            }
            if (ratingDTO.UserId == recipe.UserId)
            {
                return NotFound("Du har inte behörighet att betygsätta detta recept");
            }
            _ratingService.AddRating(ratingDTO);
            return Ok("Ditt betyg är tillagt");
        }

    }
}
