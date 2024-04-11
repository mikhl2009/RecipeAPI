using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNET_receptdatabas.Domain.Entities
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        public int Score { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }

    }
}
