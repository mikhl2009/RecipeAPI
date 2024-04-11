using System.ComponentModel.DataAnnotations;

namespace ASPNET_receptdatabas.Domain.Entities
{
    public class ApplicationUser
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

    }
}
