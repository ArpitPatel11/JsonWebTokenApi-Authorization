using System.ComponentModel.DataAnnotations;

namespace JWTTokenAPI.Models
{
    public class UserDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
