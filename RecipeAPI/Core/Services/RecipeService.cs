using ASPNET_receptdatabas.Domain.Entities;
using AutoMapper;
using RecipeAPI.Core.Interfaces;
using RecipeAPI.Data.Interfaces;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Core.Services
{
    public class RecipeService : IRecipeService
    {
        public readonly IRecipeRepo _recipeRepo;
        public readonly IMapper _mapper;

        public RecipeService(IRecipeRepo recipeRepo, IMapper mapper)
        {
            _recipeRepo = recipeRepo;
            _mapper = mapper;
        }

        public void AddRecipe(RecipeCreateDTO recipeCreateDTO)
        {
            var recipe = _mapper.Map<Recipe>(recipeCreateDTO);
            _recipeRepo.AddRecipe(recipe);
        }

        public void DeleteRecipe(int RecipeId, int UserId)
        {
            _recipeRepo.DeleteRecipe(RecipeId, UserId);
        }

        public List<RecipeReadDTO> GetAllRecipes()
        {
            var recipes = _recipeRepo.GetAllRecipes();
            var recipeReadDTOs = _mapper.Map<List<RecipeReadDTO>>(recipes);
            return recipeReadDTOs;
        }

        public void UpdateRecipe(RecipeUpdateDTO recipeUpdateDTO)
        {
            var recipe = _mapper.Map<Recipe>(recipeUpdateDTO);
            _recipeRepo.UpdateRecipe(recipe);
        }

        Recipe IRecipeService.GetRecipeById(int id)
        {
            return _recipeRepo.GetRecipeById(id);
        }

        List<RecipeReadDTO> IRecipeService.SearchRecipes(string name)
        {
            var recipes = _recipeRepo.SearchRecipes(name);
            var recipeReadDTOs = _mapper.Map<List<RecipeReadDTO>>(recipes);
            return recipeReadDTOs;

        }
    }
}
