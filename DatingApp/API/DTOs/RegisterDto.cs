using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        // [Required] means property no longer accept null values.

        [Required] 
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}