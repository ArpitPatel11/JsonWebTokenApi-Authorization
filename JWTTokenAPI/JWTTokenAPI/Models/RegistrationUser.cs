using System.ComponentModel.DataAnnotations;

namespace JWTTokenAPI.Models
{
    public class RegistrationUser
    {
        [Key]
        public int RegisterId { get; set; }
        public string Email { get; set; }
        public byte[] PassWordHash { get; set; } 
        public byte[] PassWordSalt { get; set; } 
        //public string? VeriFicationToken { get; set; }
    }
}
