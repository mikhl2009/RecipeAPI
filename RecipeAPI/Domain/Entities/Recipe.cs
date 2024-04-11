using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNET_receptdatabas.Domain.Entities
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(300)]
        public string Ingredients { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual List<Rating> Ratings { get; set; }

        public virtual Category Category { get; set; }



    }
}
