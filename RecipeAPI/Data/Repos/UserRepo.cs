using ASPNET_receptdatabas.Domain.Entities;
using RecipeAPI.Data.Interfaces;

namespace RecipeAPI.Data.Repos
{
    public class UserRepo: IUserRepo
    {
        public readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateUser(ApplicationUser user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            if (_context.Users.Find(userId) != null)
            {
                _context.Users.Remove(_context.Users.Find(userId));
                _context.SaveChanges();
            }
        }

        public List<ApplicationUser> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public ApplicationUser GetUserById(int userId)
        {
           var user = _context.Users.Find(userId);
            return user;
        }

        public ApplicationUser Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            return user;
        }

        public ApplicationUser Register(string username, string email, string password)
        {
            var user = new ApplicationUser
            {
                UserName = username,
                Email = email,
                Password = password
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void UpdateUser(int userId, string username, string email, string password = null)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                user.UserName = username;
                user.Email = email;
                if (password != null)
                {
                    user.Password = password;
                }
                _context.SaveChanges();
            }
        }
    }
}
