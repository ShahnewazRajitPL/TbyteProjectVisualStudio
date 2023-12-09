using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialAPI.TData;
using SocialAPI.TEntities;

namespace SocialAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly TDataContext _context;

        public UsersController(TDataContext context)
        {
            _context = context;
        }

        //[HttpGet]

        //public ActionResult<IEnumerable<AppUser>> GetUsers()
        //{
        // var users = _context.Users.ToList();
        //return Ok(users);
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost("id")]

        public ActionResult<AppUser>GetUsersById(int id)
        {
            var user = _context.Users.Find(id);
            return Ok(user);
        }
        
    }
}
