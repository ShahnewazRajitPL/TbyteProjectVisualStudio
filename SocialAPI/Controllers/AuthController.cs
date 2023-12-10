using Microsoft.AspNetCore.Mvc;
using SocialAPI.TData;
using SocialAPI.TDto;
using SocialAPI.TEntities;
using System.Security.Cryptography;
using System.Text;

namespace SocialAPI.Controllers
{
    public class AuthController : BaseController
    {
        private readonly TDataContext _context;

        public AuthController(TDataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> UserRegister(RegisterDto registerDto)
        {
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                UserName = registerDto.Username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt = hmac.Key
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}
