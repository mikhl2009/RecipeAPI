using ASPNET_receptdatabas.Domain.Entities;

namespace RecipeAPI.Core.Interfaces
{
    public interface IUserService
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
