using ASPNET_receptdatabas.Domain.Entities;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Core.Interfaces
{
    public interface IRecipeService
    {
        void AddRecipe(RecipeCreateDTO recipeCreateDTO);
        void DeleteRecipe(int RecipeId, int UserId);
        List<RecipeReadDTO> GetAllRecipes();
        Recipe GetRecipeById(int id);
        List<RecipeReadDTO> SearchRecipes(string name);
        void UpdateRecipe(RecipeUpdateDTO recipeUpdateDTO);

    }
}
