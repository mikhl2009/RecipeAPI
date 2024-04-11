using ASPNET_receptdatabas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace RecipeAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<ApplicationUser> Users { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }

    }
}
