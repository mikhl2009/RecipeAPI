namespace RecipeAPI.Domain.DTO
{
    public class RatingDTO
    {
        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }

    }
}
