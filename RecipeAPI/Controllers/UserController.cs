using ASPNET_receptdatabas.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Core.Interfaces;
using RecipeAPI.Domain.DTO;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            return Ok(user);
        }

        [HttpPost("Register")]
        public IActionResult Post([FromBody] ApplicationUser user)
        {
            _userService.CreateUser(user);
            return Ok("Användaren är skapad");
        }

        [HttpPut]
        public IActionResult UpdateUser(ApplicationUser user)
        {
            try
            {
                _userService.UpdateUser(user.UserId, user.UserName, user.Email, user.Password);
                return Ok("Användaren är uppdaterad");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Användaren kunde inte uppdateras");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return Ok("Användaren är borttagen");
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserDTO login)
        {
            var user = _userService.Login(login.Username, login.Password);
            if (user != null)
            {
                return Ok("Du är inloggad med UserId:" + user.UserId);
            }
            return StatusCode(StatusCodes.Status401Unauthorized, "Fel användarnamn eller lösenord");
        }
    }
}
