using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }

        // Crerated to register a user
        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> Register(string username, string password)
        {
            // Use hash function to encrypt passwords
            using var hmac = new HMACSHA512();

            // Create a new user
            var user = new AppUser
            {
                UserName = username,

                // Convert password into byte array
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key
            };

            // Add the user
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}