using ASPNET_receptdatabas.Domain.Entities;

namespace RecipeAPI.Data.Interfaces
{
    public interface IRatingRepo
    {
        void AddRating(Rating rating);
    }
}
