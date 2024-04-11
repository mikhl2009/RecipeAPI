using ASPNET_receptdatabas.Domain.Entities;

namespace RecipeAPI.Data.Interfaces
{
    public interface IUserRepo
    {
        void CreateUser(ApplicationUser user);
        void DeleteUser(int userId);
        List<ApplicationUser> GetAllUsers();
        ApplicationUser GetUserById(int userId);
        ApplicationUser Login(string username, string password);

        ApplicationUser Register(string username, string email, string password);
        void UpdateUser(int userId, string username, string email, string password = null);

    }
}
