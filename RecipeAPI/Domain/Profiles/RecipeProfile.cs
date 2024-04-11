using ASPNET_receptdatabas.Domain.Entities;
using AutoMapper;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Domain.Profiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<Recipe, RecipeReadDTO>()
              .ForMember(dto => dto.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
              .ForMember(dto => dto.UserName, opt => opt.MapFrom(src => src.User.UserName));
            CreateMap<Recipe, RecipeCreateDTO>();
            CreateMap<RecipeCreateDTO, Recipe>();
            CreateMap<RecipeReadDTO, Recipe>();
            CreateMap<Recipe, RecipeUpdateDTO>();
            CreateMap<RecipeUpdateDTO, Recipe>();
            CreateMap<Rating, RatingDTO>();
            CreateMap<RatingDTO, Rating>();
        }

    }
}
