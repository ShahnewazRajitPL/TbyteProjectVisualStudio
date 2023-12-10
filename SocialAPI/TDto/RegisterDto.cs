using System.ComponentModel.DataAnnotations;

namespace SocialAPI.TDto
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(0, MinimumLength =4)]
        public string Password { get; set; }
    }
}
