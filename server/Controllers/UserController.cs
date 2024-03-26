using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly MyDbContext _context;

        public AuthController(MyDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == request.Username && u.Password == request.Password);
            if (user == null)
                return Unauthorized();

            // Authentication successful, you may generate JWT token here
            
            return Ok(new { user.Id, user.FirstName, user.LastName });
        }
    }
}
