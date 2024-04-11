using ASPNET_receptdatabas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RecipeAPI.Data.Interfaces;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Data.Repos
{
    public class RecipeRepo : IRecipeRepo
    {
        public readonly ApplicationDbContext _context;

        public RecipeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void DeleteRecipe(int RecipeId, int UserId)
        {
            var recipe = _context.Recipes.Find(RecipeId);
            if (recipe != null && recipe.UserId == UserId)
            {
                _context.Recipes.Remove(recipe);
                _context.SaveChanges();
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            var recipes = _context.Recipes
                .Include(r => r.Category)
                .Include(r => r.User)
                .ToList();
            return recipes;
        }

        public Recipe GetRecipeById(int id)
        {
            var recipe = _context.Recipes.Find(id);
            return recipe;
        }

        public List<Recipe> SearchRecipes(string name)
        {
            var recipes = _context.Recipes.Where(r => r.Title.Contains(name))
                .Include(r => r.Category)
                .Include(r => r.User)
                .ToList();
            return recipes;
        }

        public void UpdateRecipe(Recipe recipe)
        {
            var recipeToUpdate = _context.Recipes.Find(recipe.RecipeId);
            if (recipeToUpdate != null)
            {
                recipeToUpdate.Title = recipe.Title;
                recipeToUpdate.Description = recipe.Description;
                recipeToUpdate.Ingredients = recipe.Ingredients;
                recipeToUpdate.CategoryId = recipe.CategoryId;
                _context.SaveChanges();
            }

        }

    }
}