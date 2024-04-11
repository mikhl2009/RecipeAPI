using ASPNET_receptdatabas.Domain.Entities;
using RecipeAPI.Core.Interfaces;
using RecipeAPI.Data.Interfaces;

namespace RecipeAPI.Core.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public void CreateUser(ApplicationUser user)
        {
            _userRepo.CreateUser(user);
        }

        public void DeleteUser(int userId)
        {
            _userRepo.DeleteUser(userId);
        }

        public List<ApplicationUser> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }

        public ApplicationUser GetUserById(int userId)
        {
            return _userRepo.GetUserById(userId);
        }

        public ApplicationUser Login(string username, string password)
        {
            return _userRepo.Login(username, password);
        }

        public ApplicationUser Register(string username, string email, string password)
        {
            return _userRepo.Register(username, email, password);
        }

        public void UpdateUser(int userId, string username, string email, string password = null)
        {
            _userRepo.UpdateUser(userId, username, email, password);
        }
    }
}
