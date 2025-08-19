using System.ComponentModel.DataAnnotations;

namespace Lab03JWTAPI.Domain
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Role { get; set; } // "admin" or "normal"

    }
}
