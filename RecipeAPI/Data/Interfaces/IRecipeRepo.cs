using ASPNET_receptdatabas.Domain.Entities;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Data.Interfaces
{
    public interface IRecipeRepo
    {
        void AddRecipe(Recipe recipe);
        void DeleteRecipe(int RecipeId, int UserId);
        List<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        List<Recipe> SearchRecipes(string name);
        void UpdateRecipe(Recipe recipe);
    }
}
