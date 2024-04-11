using ASPNET_receptdatabas.Domain.Entities;
using AutoMapper;
using RecipeAPI.Core.Interfaces;
using RecipeAPI.Data.Interfaces;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Core.Services
{
    public class RatingService : IRatingService
    {
        public readonly IRatingRepo _ratingRepo;
        public readonly IMapper _mapper;

        public RatingService(IRatingRepo ratingRepo, IMapper mapper)
        {
            _ratingRepo = ratingRepo;
            _mapper = mapper;
        }

        public void AddRating(RatingDTO ratingDTO)
        {
            var rating = _mapper.Map<Rating>(ratingDTO);
            _ratingRepo.AddRating(rating);
        }
    }
}

