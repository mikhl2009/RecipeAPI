using ASPNET_receptdatabas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.Data.Interfaces;

namespace RecipeAPI.Data.Repos
{
    public class RatingRepo : IRatingRepo
    {
        public readonly ApplicationDbContext _context;

        public RatingRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }
    }
}
