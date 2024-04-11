namespace RecipeAPI.Domain.DTO
{
    public class RecipeCreateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
