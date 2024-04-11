using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Core.Interfaces
{
    public interface IRatingService
    {
        void AddRating(RatingDTO ratingDTO);

    }
}
