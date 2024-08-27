using System.ComponentModel.DataAnnotations;

namespace SisemaAdopcion.Shared.Dtos
{
    public class LoginRequestDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }
}
