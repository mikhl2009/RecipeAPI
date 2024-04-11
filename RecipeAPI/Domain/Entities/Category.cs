using System.ComponentModel.DataAnnotations;

namespace ASPNET_receptdatabas.Domain.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public List<Recipe> Recipes { get; set; }
    }
}
